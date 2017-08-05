(function () {
    var initialColor = '';

    $.fn.highlight = function () {
        initialColor = this.css('background-color');
        this.css('background-color', '#ff6801');
        this.addClass('highlit');
    };

    $.fn.removeHighlight = function () {
        this.css('background-color', initialColor);
        this.removeClass('highlit');
    };
})(jQuery);