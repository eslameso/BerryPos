// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(){
    $('.myselect-option').on({'click': function() {
        if($('.langselect').attr('src') == "/imgs/en.png"){
            $('.langselect').attr({"src" : "/imgs/ar.png", "title" : "عربي"});
            $('.langopt').attr('src', "/imgs/en.png");
            $('.langHover input').value="ar";
            // $('.langName').text("En");
            console.log($('.langHover input').value);
            $("html").attr('dir','rtl');
        }else if($('.langselect').attr('src') == "/imgs/ar.png"){
            $('.langselect').attr({"src":"/imgs/en.png", "title" : "English"});
            $('.langopt').attr('src', "/imgs/ar.png");
            $('.langHover input').value="en";
            // $('.langName').text("Ar");
            $("html").attr('dir','ltr');
        }
        $(".myselect-option").trigger('change');  
    }
    });
  

    $(".nav-item").click(function () {
        $(".nav-item").removeClass("active");
        $(this).addClass("active");   
    });
});
