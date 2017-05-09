$(document).ready(function () {
    $('.add-contact').click(function () {
        console.log("look at me")
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '/Contact/ShowContactSave',
            success: function (result) {
                $('#new-contact').html(result);
                $('.add-new-cont').submit(function (event) {
                    console.log("we are here")
                    event.preventDefault();
                    $.ajax({
                        url: '/Contact/NewContact',
                        type: 'POST',
                        datatype: 'json',
                        data: $(this).serialize(),
                        success: function (result) {
                            console.log(result);
                            var contactAdded = result.name + " has been added to your contact list."
                            $('#saved-contact').html(contactAdded);
                            window.setTimeout(function () { location.reload() }, 2000);
                        }
                    });
                });

            }// end success of initial ajax req
        });
    });
    $('.contact-entry').click(function () {
        console.log($(this).context.id);
        var clickedCont = $(this).context.id;
        $.ajax({
            type: 'GET',
            data: { id: clickedCont },
            dataType: 'html',
        url: '/Contact/Edit',
        success: function (result){
            $('#edit-' + clickedCont).html(result);
        }
        });
    });
            $('.edit-contact').click(function () {
                event.preventDefault;
                $.ajax({
                    type: 'POST',
                    data: $(this).serialize(),
                    dataType: 'json',
                    success: function (result) {
                        var edited = "You have edited " + result.name + " and " + result.number
                        $('#edit').html(edited);
                       location.reload();
                    }
                });
            });
});// end document eady bracket