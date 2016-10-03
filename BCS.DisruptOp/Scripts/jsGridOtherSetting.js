//$(document).ready(function () {

//    $("#jsGrid").jsGrid({
//          autoload: false
//        , controller: {
//            //loadData: function (filter) {
//            //    alert("loadData is working.");
//            //        return $.ajax({
//            //            type: "POST"
//            //            , url: "/Disrupt/GetFlights"
//            //            , success: function (data) {
//            //                alert("here" + data.d.toString());
//            //            }
//            //            , error: function (data) {
//            //                alert("here" + data.d.toString());
//            //            }
//            //            , data: filter
//            //            , dataType: "JSON"
//            //        }).done(function (response) {
//            //            d.resolve(response.value);
//            //            alert(response.value);
//            //        });
//            //    }
//            loadData: function (filter) {
//                var data = $.Deferred();
//                alert("code enters loadData");
//                $.ajax({
//                      type: "POST"
//                    , url: "/Disrupt/GetFlights"
//                }).done(function (response) {
//                    data.resolve(response);
//                    alert("test");
//                });
//                return data.promise();
//            }
//            //loadData: $.noop
//            , insertItem: $.noop
//            , updateItem: $.noop
//            , deleteItem: $.noop
//        }

//        , heading: true
//        , filtering: false
//        , selecting: true
//        , pageLoading: false

//        , rowClass: function(item, itemIndex) {  }
//        , rowClick: function(args) {  }
//        , rowDoubleClick: function(args) {  }
 
//        , noDataContent: "not found"
 
//        , confirmDeleting: true
//        , deleteConfirm: "Are you sure?"
 
//        , pagerContainer: null
//        , pageIndex: 1
//        , pageSize: 20
//        , pageButtonCount: 15
//        , pagerFormat: "Pages: {first} {prev} {pages} {next} {last}    {pageIndex} of {pageCount}"
//        , pagePrevText: "Prev"
//        , pageNextText: "Next"
//        , pageFirstText: "First"
//        , pageLastText: "Last"
//        , pageNavigatorNextText: "..."
//        , pageNavigatorPrevText: "..."
 
//        , invalidNotify: function(args) {  }
//        , invalidMessage: "Invalid data entered!"
 
//        , loadIndication: true
//        , loadIndicationDelay: 500
//        , loadMessage: "Please, wait..."
//        , loadShading: true
 
//        , updateOnResize: true
 
//        , rowRenderer: null
//        , headerRowRenderer: null
//        , filterRowRenderer: null
//        , insertRowRenderer: null
//        , editRowRenderer: null

//        //, fields: [
//        //    {
//        //        name: "Name"
//        //        , align: ""
//        //        , visible: true
//        //    },
//        //    {
//        //        name: "Age"
//        //        , css: ""
//        //        , headercss: ""
//        //        , filtercss: ""
//        //        , insertcss: ""
//        //        , editcss: ""
//        //    },
//        //    {
//        //        name: "Address"
//        //        , filtering: true
//        //        , inserting: true
//        //        , editing: true
//        //        , sorter: "string"
//        //    },
//        //    {
//        //        name: "Country"
//        //        , headerTemplate: function() {  }
//        //        , itemTemplate: function(value, item) {  }
//        //        , filterTemplate: function() {  }
//        //        , insertTemplate: function() {  }
//        //        , editTemplate: function(value, item) {  }
//        //    },
//        //    {
//        //        name: "Married"
//        //        , filterValue: function() {  }
//        //        , insertValue: function() {  }
//        //        , editValue: function() {  }
 
//        //        , cellRenderer: null
 
//        //        , validate: null
//        //    }
//        //    , { type: "control" }
//        //]//fields
//    });
//});
