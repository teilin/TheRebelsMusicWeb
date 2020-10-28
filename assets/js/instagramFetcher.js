(function($) {
    "use strict";

    $(window).on("load", function() {
        $.instagramFeed({
            'username': 'therebels_band',
            'display_profile': false,
            'display_biography': false,
            'display_gallery': false,
            'callback': function(data) {
                let nodeArray = data.edge_owner_to_timeline_media.edges.slice(0,9);
                $('.popup-image').each(function(key) {
                    let instagramNode = nodeArray[key];
                    $(this).attr('href', "https://www.instagram.com/p/"+instagramNode.node.shortcode+"/");
                    $(this).find('img').attr('src', instagramNode.node.thumbnail_resources[2].src);
                });
            },
            'styling': false
        });
    });
})(jQuery);