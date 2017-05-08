$(document).ready(function () {
    $('.add-contact').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '/Contact/ShowContactSave',
            success: function (result) {
                $('#new-contact').html(result);
            }// end success of initial ajax req
        });
    });
});// end document eady bracket