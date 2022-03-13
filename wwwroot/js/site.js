// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$(document).ready(function(){
    // $('.culSelect option').on({'click': function() {
        // if(($(".culSelect").val() == "ar") && ($('.langselect').attr('src') == "/imgs/en.png" )){
        //     $('.langselect').attr({"src" : "/imgs/ar.png", "title" : "عربي"});
        //     $('.langopt').attr('src', "/imgs/en.png");
        //     $("html").attr('dir','rtl');
        //     // $(".langSelect").val('en').change();
        //     // console.log($(".langSelect").val('en').change());
        // }else if(($(".culSelect").val() == "en") && ($('.langselect').attr('src') == "/imgs/ar.png")){
        //     $('.langselect').attr({"src":"/imgs/en.png", "title" : "English"});
        //     $('.langopt').attr('src', "/imgs/ar.png");
        //     // $(".langSelect option[value='en']").attr('selected', 'selected');
        //     $("html").attr('dir','ltr');
        //     // $(".langSelect").val('ar').change();
        // }
        // $(".myselect-option").trigger('change');  
    // }
    // });

        // var cultureInfo = @Culture.RequestCulture.UICulture.Name;
              
        if($('#langs').val() == 'ar'){
            $("html").attr('dir','rtl');
        }else if($('#langs').val() == 'en'){
            $("html").attr('dir','ltr');
        }
          
      

    $(".nav-item").click(function () {
        $(".nav-item").removeClass("active");
        $(this).addClass("active");   
    });
});

// $('html').on({'load': function() {

//         var cultureInfo = '@System.Globalization.CultureInfo.CurrentCulture.Name';
//         console.log(cultureInfo);
//         if(cultureInfo == 'ar'){
//             $("html").attr('dir','rtl');
//         }else if(cultureInfo == 'en' ){
//             $("html").attr('dir','ltr');
//         }
//      }
    
//  });

