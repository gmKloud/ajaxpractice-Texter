$(document).ready(function () {
    $('.add-contact').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '/Contact/ShowContactSave',
            success: function (result) {
                $('#new-contact').html(result);
            $.ajax({
            url: '/Contact/Create',
            type: 'POST',
            datatype: 'json',
            data: $(this).serialize(),
            success: function (result) {
                var saved = result.Name + " has been added to you contact list."
                    $('#saved-contact').html(saved);
                 }
               });
            }// end success of initial ajax req
        });
    });
});// end document eady bracket