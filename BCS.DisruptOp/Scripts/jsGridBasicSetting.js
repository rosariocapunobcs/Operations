$(document).ready(function () {

    $disruptBasicSettings = $disrupt;

    $disruptBasicSettings.load = {
        gridLabel: $disruptBasicSettings.initialize.gridLabel
        , otherSettings : function () {
            $($disruptBasicSettings.load.gridLabel).jsGrid({
                width: "100%"
                , height: "400px"

                , inserting: true
                , editing: true
                , sorting: true
                , paging: true

                //, data: $clients
                , data: $flights
                , fields: $disruptFields
            });
        }
    }

    $disruptBasicSettings.load.otherSettings();
//    $($disrupt.initialize.gridLabel).jsGrid({
//          width: "100%"
//        , height: "400px"

//        , inserting: true
//        , editing: true
//        , sorting: true
//        , paging: true

////        //, data: $clients
//        , data: $flights
//        , fields: $disruptFields

//        /*
//        , fields: [
//            {
//                name: "CarrierCode"
//                , title: "Carrier Code"
//                , type: "text"
//                , validate: "required"
//            },//1
//            {
//                name: "Number"
//                , title: "Flight Number"
//                , type: "number"
//            },//2
//            {
//                name: "Origin"
//                , type: "text"
//            },//3
//            {
//                name: "Destination"
//                , type: "text"
//            },//4
//            {
//                name: "STD"
//                , type: "text"
//            },//5
//            {
//                name: "STA"
//                , type: "text"
//            },//6
//            {
//                name: "SeverityLevel"
//                , title: "Severity Level"
//                , type: "text"
//                //, type: "select"
//                //, items: $severities
//                //, valueField: "Id"
//                //, textField: "Name"
//            },//7
//            {
//                name: "PaxDLOriginal"
//                , title: "Pax DL Original"
//                , type: "number"
//            },//8
//            {
//                name: "PaxDLLive"
//                , title: "Pax DL Live"
//                , type: "number"
//            },//9
//            {                                 
//                name: "DisruptReason"
//                , title: "Disrupt Reason"
//                , type: "text"
//            //    type: "control"             
//            },//10
//            {                             
//                name: "RecoveryPolicy"
//                , title: "Recovery Policy"
//                , type: "text"
//            //    type: "control"             
//            },//11
//            {                                 
//                name: "RecoveryPlan"
//                , title: "Recovery Plan"
//                , type: "text"
//            //    type: "control"             
//            },//12
//            {                                 
//                name: "StaffComms"
//                , title: "Staff Comms"
//                , type: "text"
//            //    type: "control"             
//            },//13
//            {                                 
//                name: "CustomerComms"
//                , title: "Customer Comms"
//                , type: "text"
//            //    type: "control"             
//            },//14
//            {                                 
//                name: "Event"
//                , title: "Event"
//                , type: "text"            
//            }//15    
//            , { type: "control" }
//        ]//fields
//        */
////        //, fields: [
////        //    {
////        //          name: "Name"
////        //        , type: "text"
////        //        , width: 150
////        //        , validate: "required"
////        //    },
////        //    {
////        //          name: "Age"
////        //        , type: "number"
////        //        , width: 50
////        //    },
////        //    {
////        //          name: "Address"
////        //        , type: "text"
////        //        , width: 200
////        //    },
////        //    {
////        //          name: "Country"
////        //        , type: "select"
////        //        , items: $countries
////        //        , valueField: "Id"
////        //        , textField: "Name"
////        //    },
////        //    {
////        //          name: "Married"
////        //        , type: "checkbox"
////        //        , title: "Is Married"
////        //        , sorting: false
////        //    }
////        //    , { type: "control" }
////        //]//fields
//    });
});
