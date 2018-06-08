$(document).ready(function () {
    console.log('GET LOUD');

    $("#person").click(function () {
        $.ajax({
            url: "/Login/LoginPartial",
            success: function (result) {
                $("#login_partial").html(result);
                $("#login_partial.html").show();
            }
        });
    });

    });

 