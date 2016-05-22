$(document).ready(function () {

    $("[id$=cmbrol]").change(function () {
      
        if ($(this).val() == 1)
            $("[id$=cmbcarrera]").attr("disabled", "disabled");
        else
            $("[id$=cmbcarrera]").removeAttr("disabled");

    });

});
