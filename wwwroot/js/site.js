// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(){
    $('.myselect-option').on({'click': function() {
            if($('.langselect').attr('src') == "/imgs/en.png"){
                $('.langselect').attr({"src" : "/imgs/ar.png", "title" : "عربي"});
                $('.langopt').attr('src', "/imgs/en.png");
                $('.langName').text("En");
                console.log( $("html").children().css("direction"));
                $("html").attr('dir','rtl');
            }else if($('.langselect').attr('src') == "/imgs/ar.png"){
                $('.langselect').attr({"src":"/imgs/en.png", "title" : "English"});
                $('.langopt').attr('src', "/imgs/ar.png");
                $('.langName').text("Ar");
                $("html").attr('dir','ltr');
            }
        }
    });
    $(".nav-item").click(function () {
        $(".nav-item").removeClass("active");
        $(this).addClass("active");   
    });
});
