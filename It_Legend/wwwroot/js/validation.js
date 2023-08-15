
//////////////


var Validation = {
    IsValidEntry: function (field, scroll = false, minLength = 0) {
        try {
            debugger
            var value = field.value;
            if (value == null || value == "" || value == "null" || value < 0) {
                document.getElementById(field.id + "Validation").style.display = "block";
                $(`#${field.id} `).removeClass("is-valid");
                $(`#${field.id} `).addClass("is-invalid");
                if (scroll && field != null) field.scrollIntoView();
                try {
                    document.getElementById(field.id + "ValidationMinLength").style.display = "block";
                } catch (e) { }
                return false;
            } else if (value.length <= minLength) {
                document.getElementById(field.id + "Validation").style.display = "none";
                $(`#${field.id} `).addClass("is-valid");
                $(`#${field.id} `).removeClass("is-invalid");
                document.getElementById(field.id + "ValidationMinLength").style.display = "block";
                $(`#${field.id} `).removeClass("is-valid");
                $(`#${field.id} `).addClass("is-invalid");
                if (scroll && field != null) field.scrollIntoView();
                return false;
            }
            else {
                document.getElementById(field.id + "Validation").style.display = "none";
                try {
                    document.getElementById(field.id + "ValidationMinLength").style.display = "none";
                } catch (e) { }
                $(`#${field.id} `).removeClass("is-invalid");
                $(`#${field.id} `).addClass("is-valid");
            }
            return true;

        } catch (e) {
            console.log(value);
            console.log(field);
            return false;
        }
    },

    IsValidBasicData: function () {
        var isValid = true;
        debugger;
        var reqiredFields = document.getElementsByClassName("isRequired");
        for (var i = reqiredFields.length - 1; i >= 0; i--) {
            var isValidEntry = Validation.IsValidEntry(reqiredFields[i], true);
            isValid = isValidEntry && isValid;
        }
        return isValid
    },

}
