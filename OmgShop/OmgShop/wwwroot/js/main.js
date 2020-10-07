$(document).ready(function() {
	// Fixed Header
	function fixHeader() {
		var header = $(".header");

		if ($(window).scrollTop() > 0) {
			header.addClass("header_fixed");
		}
		else {
			header.removeClass("header_fixed");
		}		
	}

	fixHeader();

	$(window).scroll(function() {
		fixHeader();	
	});
	
	// Header Nav
	$(".header__nav-toggle").click(function() {
		$(this).toggleClass("header__nav-toggle_active");

		$(".header__nav-content").slideToggle(200);
	});

    // Modal Windows
    function openModal(el, modal) {
    	$.fancybox.close();

        $.fancybox.open({
            src: modal,
            opts: {
            	autoFocus: false,
                touch: false     
            }
        });     
    }  

    $(document).on("click", "[data-modal]", function(e) {
    	e.preventDefault();

        openModal($(this), $(this).attr("href"));
    });          

    $(".modal__form").submit(function() {
        parent.$.fancybox.getInstance().close();
    });  
});