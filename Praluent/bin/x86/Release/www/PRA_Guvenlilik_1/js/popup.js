function popup(_file, _x, _y) {
    $('body').append('<div id="pyk_pop" style="opacity:0;width:1920px;height:1080px;display:block;position:absolute;left:0;top:0;z-index:1000"><style>@keyframes ani-bubble{from{transform:scale(0)}to{transform:scale(1)}}.popupbubble{animation-name:ani-bubble;animation-duration:.4s}</style></div>');
    $('#pyk_pop').append('<img src="' + active + '/media/images/' + _file + '" class="popupbubble" style="width:1440px;height:1080px;position:absolute;left:240px;top:0px;z-index:10001" />');
    $('#pyk_pop').append('<img src="' + active + '/media/images/pop_bg.png" />');
    $('#pyk_pop').animate({
        opacity: 1
    }, 500, function() {
        $('#pyk_pop img').click(function() {
            $('#pyk_pop').animate({
                opacity: 0
            }, 500, function() {
                $("#pyk_pop").remove();
            });
        });
    });
}

