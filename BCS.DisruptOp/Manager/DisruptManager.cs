using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml;

using Newtonsoft.Json;

using BCS.DisruptOp.Mapper;
using BCS.DisruptOp.Models;

namespace BCS.DisruptOp.Manager
{
    public class DisruptManager
    {
        private static FlightsEntities _flightsEntities = new FlightsEntities();

        #region Create
        public void CreateFlight(FlightModel flight)
        {
            Disrupt disrupt = FlightMapper.ExtractDisrupt(flight);
            _flightsEntities.Disrupts.Add(disrupt);
            _flightsEntities.SaveChanges();
        }

        public Recovery CreateRecovery(Recovery recovery)
        {
            _flightsEntities.Recoveries.Add(recovery);
            _flightsEntities.SaveChanges();

            Recovery query = GetRecovery(recovery);
            return query;
        } 
        #endregion

        #region Read
        public FieldJSON SerializeDisruptFieldOrder()
        {
            DataContractSerializer serializerDisruptFieldOrder = new DataContractSerializer(typeof(FieldJSON));

            string pathDisruptFieldOrder = HttpContext.Current.Server.MapPath("~/Settings/DisruptFieldOrder.xml");
            FieldJSON fieldJSON = new FieldJSON();

            using (FileStream fs = new FileStream(pathDisruptFieldOrder, FileMode.Open, FileAccess.Read))
            {
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

                fieldJSON = (FieldJSON)serializerDisruptFieldOrder.ReadObject(reader);
                reader.Close();
                fs.Close();
            }

            return fieldJSON;
        }

        public int ExistsRecovery(Recovery recovery)
        {
            Recovery query = GetRecovery(recovery);

            if ((query.Plan != "" || query.Plan != null)
                && (query.Policy != "" || query.Policy != null))
            {
                return query.Id;
            }

            return 0;
        }

        public Recovery GetRecovery(Recovery recovery)
        {
            Recovery query = _flightsEntities.Recoveries.Where(rec => rec.Plan == recovery.Plan && rec.Policy == recovery.Policy).First();
            return query;
        }
        #endregion

        #region Update
        public void UpdateFlight(FlightModel flight)
        {
            Disrupt disrupt = FlightMapper.ExtractDisrupt(flight);
            Recovery recovery = new Recovery();
            recovery.Plan = flight.RecoveryPlan;
            recovery.Policy = flight.RecoveryPolicy;
            Recovery query = GetRecovery(recovery);

            try
            {
                //_flightsEntities.Entry(flight).State = EntityState.Modified;
                _flightsEntities.Entry(disrupt).State = EntityState.Modified;
                _flightsEntities.Entry(query).State = EntityState.Modified;
            }
            catch (Exception exception)
            {
                
            }

            _flightsEntities.SaveChanges();
        }
        #endregion
    }
}