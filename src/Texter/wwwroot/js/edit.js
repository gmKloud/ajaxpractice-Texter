//$(function () {

//    var id = $('#id').val();
//    $('#' + id).submit(function (event) {
//        console.log("You've made it")
//        event.preventDefault;
//        console.log($(this).serialize());
//        $.ajax({
//            type: 'POST',
//            data: $(this).serialize(),
//            dataType: 'json',
//            url: '/Contact/Edit',
//            success: function (result) {
//                console.log(result);
//                var edited = "You have edited " + result.name + " : " + result.number
//                $('#edit').html(edited);
//                location.reload();
//            }
//        });
//    });
//});