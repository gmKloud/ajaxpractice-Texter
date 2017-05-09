$(document).ready(function () {
    $('.add-contact').click(function () {
        $.ajax({
            type: 'GET',
            dataType: 'html',
            url: '/Contact/ShowContactSave',
            success: function (result) {
                $('#new-contact').html(result);
                $('.add-new-cont').submit(function (event) {
                    event.preventDefault();
                    $.ajax({
                        url: '/Contact/NewContact',
                        type: 'POST',
                        datatype: 'json',
                        data: $(this).serialize(),
                        success: function (result) {
                            console.log(result);
                            var contactAdded = " has been added to your contact list."
                            $('#saved-contact').html(contactAdded);
                            window.setTimeout(function () { location.reload() }, 1000);
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
            url: '/Contact/EditShow',
            success: function (result) {
                console.log("Success first AJAX call");
                $('#edit-' + clickedCont).html(result);
                console.log($('.special-test-value').val());

                $('.edit-contact').submit(function (e) {

                    e.preventDefault;
                    console.log("Inside second level click function");
                    $.ajax({
                        type: 'POST',
                        data: $(this).serialize(),
                        dataType: 'json',
                        url: '/Contact/Edit/',
                        success: function (result) {
                            console.log("Inside second level success");
                            var edited = "You have edited " + result.name + " : " + result.number
                            $('#edit').html(edited);
                            location.reload();
                        }
                    });
                });
            }
        });
    });
    $('.special-test-button').click(function () {
        console.log("hello");
    })
});// end document eady bracket