// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.
$(function () {
    $('[data-toggle="tooltip"]').tooltip({ trigger: 'manual' }).tooltip('show');
});

// $( window ).scroll(function() {   
// if($( window ).scrollTop() > 10){  // scroll down abit and get the action   
$(".progress-bar").each(function () {
    each_bar_width = $(this).attr('aria-valuenow');
    $(this).width(each_bar_width + '%');
});

 //  }  
// });
