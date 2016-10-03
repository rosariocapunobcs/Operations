$(function () {
    $utility = {};

    $utility.Collection = {
          regExForName: ""
        , regExForPhone: ""
        , validateName: function (name) {
            // Do something with name, you can access regExForName variable
            // using "this.regExForName"
        }

        , exists: function (item, collection, resultField) {
            for (i = 0; i < collection.length; i++) {
                if (item == $flights[i]) {
                    $(resultField).text("dsfjdshfkjds");
                    return true;
                }
            }
        }
    }
});
