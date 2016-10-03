$(function () {
    $flights = [];
    $disruptFields = [];

    $disrupt = {};

    $disrupt.initialize = {
          gridLabel: "#jsGrid"
        , getDisruptFieldOrder: function() {
            $.ajax({
                url: "/Disrupt/GetDisruptFieldOrder"
                , async: false
                , dataType: "json"
                , success: function (data) {

                    for (i = 0; i < data.FieldList.length; i++) {
                        $disruptFields.push({
                            name: data.FieldList[i].Name
                            , title: data.FieldList[i].Title
                            , type: data.FieldList[i].Type
                            , validate: data.FieldList[i].Validate
                        });
                    }
                }
            });
        }

        , getFlights: function() {
            $.ajax({
                url: "/Disrupt/GetFlights"
                , async: false
                , dataType: "json"
                , success: function (data) {
                    $flights = data;
                }
            });
        }

        , loadGrid: function () {
            $($disrupt.initialize.gridLabel).jsGrid({

                controller: {
                    //    loadData: function () {
                    //        var d = $.Deferred();

                    //        $.ajax({
                    //            url: "/Disrupt/GetFlights",
                    //            dataType: "json",
                    //            data: $flights
                    //            , success: function (data) {
                    //                $flights = data[0];
                    //            }
                    //        }).done(function (response) {
                    //            d.resolve(response.value);
                    //        });

                    //        return d.promise();
                    //    },
                    //    insertItem: $.noop,
                    insertItem: function (item) {
                        return $.ajax({
                            //type: "POST",
                            url: "/Disrupt/CreateFlight"
                            , data: item
                        });
                    }
                    //    updateItem: $.noop,
                   , updateItem: function (item) {

                       if ($utility.Collection.exists(item, $flights, "#error")) { return; }

                       return $.ajax({
                           type: "PUT",
                           url: "/Disrupt/UpdateFlight"
                           , data: item
                       });
                   }
                    //    deleteItem: $.noop
                }
            });
        }
    }

    $disrupt.initialize.getDisruptFieldOrder();
    $disrupt.initialize.getFlights();
    $disrupt.initialize.loadGrid();
});

//$(document).ready(function () {

////    $flights = [
////    {
////        "FlightCarrierCode":"5J"
////        ,"FlightNumber":12
////        ,"Origin":"Manila"
////        ,"Destination":"Davao"
////        ,"STD":9212016
////        ,"STA":9222016
////        ,"SeverityLevel":"Critical"
////        ,"PaxDLOriginal":13
////        ,"PaxDLLive":9212016
////    }
////    ];//flights

//    $severities = [
//        {
//            Name: ""
//            , Id: 0
//        }
//        , {
//            Name: "Critical"
//            , Id: 1
//        }
//        , {
//            Name: "High"
//            , Id: 2
//        }
//        , {
//            Name: "Medium"
//            , Id: 3
//        }
//    ];//severities

////    $clients = [
////        {
////              "Name": "Otto Clay"
////            , "Age": 25
////            , "Country": 1
////            , "Address": "Ap #897-1459 Quam Avenue"
////            , "Married": false
////        }
////        , {
////              "Name": "Connor Johnston"
////            , "Age": 45
////            , "Country": 2
////            , "Address": "Ap #370-4647 Dis Av."
////            , "Married": true
////        }
////        , {
////              "Name": "Lacey Hess"
////            , "Age": 29
////            , "Country": 3
////            , "Address": "Ap #365-8835 Integer St."
////            , "Married": false
////        }
////        , {
////              "Name": "Timothy Henson"
////            , "Age": 56
////            , "Country": 1
////            , "Address": "911-5143 Luctus Ave"
////            , "Married": true
////        }
////        , {
////            "Name": "Ramona Benton"
////            , "Age": 32
////            , "Country": 3
////            , "Address": "Ap #614-689 Vehicula Street"
////            , "Married": false
////        }
////    ];//clients

////    $countries = [
////        { Name: "", Id: 0 }
////        , {
////              Name: "United States"
////            , Id: 1
////        }
////        , {
////              Name: "Canada"
////            , Id: 2
////        }
////        , {
////              Name: "United Kingdom"
////            , Id: 3
////        }
////    ];//countries
////});

////SAMPLE 
////$(function () {

////    $("#jsGrid").jsGrid({
////        height: "auto",
////        width: "100%",

////        sorting: true,
////        paging: false,
////        autoload: true,

////        controller: {
////            loadData: function () {
////                var d = $.Deferred();

////                $.ajax({
////                    url: "http://services.odata.org/V3/(S(3mnweai3qldmghnzfshavfok))/OData/OData.svc/Products",
////                    dataType: "json"
////                }).done(function (response) {
////                    d.resolve(response.value);
////                });

////                return d.promise();
////            }
////        },

////        fields: [
////            { name: "Name", type: "text" },
////            { name: "Description", type: "textarea", width: 150 },
////            {
////                name: "Rating", type: "number", width: 50, align: "center",
////                itemTemplate: function (value) {
////                    return $("<div>").addClass("rating").append(Array(value + 1).join("&#9733;"));
////                }
////            },
////            {
////                name: "Price", type: "number", width: 50,
////                itemTemplate: function (value) {
////                    return value.toFixed(2) + "$";
////                }
////            }
////        ]
////    });

//});