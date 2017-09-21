function showNote(div, close) {

    $('.pdisplay').hide();
    if (!close) {
        var _object = $('#' + div);
        var _top = _object.css('top').replace(/[^-\d\.]/g, '');
        _object.css({ top: _top - 20, opacity: 0 }).show().animate({ top: _top, opacity: 1 }, 200);
        $(window).mouseup(closeAll);
        _object.click(closeAll);
    }
}

function closeAll(){
    $('.pdisplay').hide();
    showNote(null,true);
}