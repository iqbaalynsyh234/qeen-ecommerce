(function ($) {
	"use strict";
	$('select').niceSelect();

	/*-----------------------------------------
            global slick slicer control
        ------------------------------------------*/
	var globalSlickInit = $('.global-slick-init');
	if (globalSlickInit.length > 0) {

		//todo have to check slider item
		$.each(globalSlickInit, function (index, value) {
			if ($(this).children('div').length > 1) {

				//todo configure slider settings object
				var sliderSettings = {};
				var allData = $(this).data();
				var infinite = typeof allData.infinite == 'undefined' ? false : allData.infinite;
				var arrows = typeof allData.arrows == 'undefined' ? false : allData.arrows;
				var autoplay = typeof allData.autoplay == 'undefined' ? false : allData.autoplay;
				var focusOnSelect = typeof allData.focusonselect == 'undefined' ? false : allData.focusonselect;
				var swipeToSlide = typeof allData.swipetoslide == 'undefined' ? false : allData.swipetoslide;
				var slidesToShow = typeof allData.slidestoshow == 'undefined' ? 1 : allData.slidestoshow;
				var slidesToScroll = typeof allData.slidestoscroll == 'undefined' ? 1 : allData.slidestoscroll;
				var speed = typeof allData.speed == 'undefined' ? '500' : allData.speed;
				var dots = typeof allData.dots == 'undefined' ? false : allData.dots;
				var cssEase = typeof allData.cssease == 'undefined' ? 'linear' : allData.cssease;
				var prevArrow = typeof allData.prevarrow == 'undefined' ? '' : allData.prevarrow;
				var nextArrow = typeof allData.nextarrow == 'undefined' ? '' : allData.nextarrow;
				var centerMode = typeof allData.centermode == 'undefined' ? false : allData.centermode;
				var centerPadding = typeof allData.centerpadding == 'undefined' ? '50px' : allData.centerpadding;
				var rows = typeof allData.rows == 'undefined' ? 1 : parseInt(allData.rows);
				var autoplay = typeof allData.autoplay == 'undefined' ? false : allData.autoplay;
				var autoplaySpeed = typeof allData.autoplayspeed == 'undefined' ? 2000 : parseInt(allData.autoplayspeed);
				var lazyLoad = typeof allData.lazyload == 'undefined' ? false : allData.lazyload; // have to remove it from settings object if it undefined
				var appendDots = typeof allData.appenddots == 'undefined' ? false : allData.appenddots;
				var appendArrows = typeof allData.appendarrows == 'undefined' ? false : allData.appendarrows;
				var asNavFor = typeof allData.asnavfor == 'undefined' ? false : allData.asnavfor;
				var verticalSwiping = typeof allData.verticalswiping == 'undefined' ? false : allData.verticalswiping;
				var vertical = typeof allData.vertical == 'undefined' ? false : allData.vertical;
				var fade = typeof allData.fade == 'undefined' ? false : allData.fade;
				var rtl = typeof allData.rtl == 'undefined' ? false : allData.rtl;
				var responsive = typeof $(this).data('responsive') == 'undefined' ? false : $(this).data('responsive');

				//slider settings object setup
				sliderSettings.infinite = infinite;
				sliderSettings.arrows = arrows;
				sliderSettings.autoplay = autoplay;
				sliderSettings.focusOnSelect = focusOnSelect;
				sliderSettings.swipeToSlide = swipeToSlide;
				sliderSettings.slidesToShow = slidesToShow;
				sliderSettings.slidesToScroll = slidesToScroll;
				sliderSettings.speed = speed;
				sliderSettings.dots = dots;
				sliderSettings.cssEase = cssEase;
				sliderSettings.prevArrow = prevArrow;
				sliderSettings.nextArrow = nextArrow;
				sliderSettings.rows = rows;
				sliderSettings.autoplaySpeed = autoplaySpeed;
				sliderSettings.autoplay = autoplay;
				sliderSettings.verticalSwiping = verticalSwiping;
				sliderSettings.vertical = vertical;
				sliderSettings.rtl = rtl;

				if (centerMode != false) {
					sliderSettings.centerMode = centerMode;
				}
				if (centerPadding != false) {
					sliderSettings.centerPadding = centerPadding;
				}
				if (lazyLoad != false) {
					sliderSettings.lazyLoad = lazyLoad;
				}
				if (appendDots != false) {
					sliderSettings.appendDots = appendDots;
				}
				if (appendArrows != false) {
					sliderSettings.appendArrows = appendArrows;
				}
				if (asNavFor != false) {
					sliderSettings.asNavFor = asNavFor;
				}
				if (fade != false) {
					sliderSettings.fade = fade;
				}
				if (responsive != false) {
					sliderSettings.responsive = responsive;
				}
				$(this).slick(sliderSettings);
			}
		});
	}

	/*------------------------------
            Header Slider index-04
        -------------------------------*/

	$('.home-05-banner').slick({
		dots: false,
		infinite: true,
		speed: 1500,
		cssEase: 'ease-In-out',
		arrows: false,
		autoplay: true,
		centerMode: true,
		autoplaySpeed: 2500,
		slidesToShow: 1,
		slidesToScroll: 1,
		centerPadding: '270px',
		prevArrow: '<div class="prev-arrow"><i class="las la-angle-left"></i></div>',
		nextArrow: '<div class="next-arrow"> <i class="las la-angle-right"></i></div>',

		responsive: [

			{
				breakpoint: 1367,
				settings: {
					centerPadding: '200px',
				}
			},

			{
				breakpoint: 993,
				settings: {
					centerPadding: '150px',
				}
			},
			{
				breakpoint: 992,
				settings: {
					centerMode: false,
				}
			}
		]
	});

	/*------------------------------
            menu toggle
    -------------------------------*/

	$(document).on('click', '#menu-icon', function (e) {
		if ($(this).is(':checked')) {
			$('#menux').addClass('show');
			localStorage.setItem('qt_is_dark', 1)
		} else {
			$('#menux').removeClass('show');
			localStorage.setItem('qt_is_dark', 0)
		}
	});

	window.onload = function () {
		setInterval(function () {
			$(".loading").fadeOut(100);
		}, 500);

		// set dark mode state
		if (Number(localStorage.getItem('qt_is_dark'))) {
			$('#menux').addClass('show');
			$('#menu-icon').attr('checked', true)
		}
	};


	/*------------------------------------
        dark version control
    -----------------------------------*/
	$(document).on('click', '#dark-version', function (e) {
		if ($(this).is(':checked')) {
			$('body').addClass('dark');
			localStorage.setItem('qt_is_dark', 1)
		} else {
			$('body').removeClass('dark');
			localStorage.setItem('qt_is_dark', 0)
		}
	});

	window.onload = function () {
		setInterval(function () {
			$(".loading").fadeOut(100);
		}, 500);

		// set dark mode state
		if (Number(localStorage.getItem('qt_is_dark'))) {
			$('body').addClass('dark');
			$('#dark-version').attr('checked', true)
		}
	};

	/*------------------------------------
       header search 
    -----------------------------------*/
	$("#search-01").on('click', function () {
		$('.search-box-absolute').toggleClass('show');
	});

	// meanmenu
	$('#mobile-menu').meanmenu({
		meanMenuContainer: '.mobile-menu',
		meanScreenWidth: "992"
	});

	$('.open-mobile-menu').on('click', function () {
		$('.side-info').addClass('info-open');
		$('.offcanvas-overlay').addClass('overlay-open');
	})

	$('.side-info-close,.offcanvas-overlay,.mobile_one_page li.menu-item a.nav-link').on('click', function () {
		$('.side-info').removeClass('info-open');
		$('.offcanvas-overlay').removeClass('overlay-open');
	})

	//sidebar
	$('.open-sidebar').on('click', function () {
		$('.offcanvas-menu-wrap').addClass('sidebar-open');
		$('.offcanvas-overlay').addClass('overlay-open');
	})

	$('.side-info-close,.offcanvas-overlay,.close-btn').on('click', function () {
		$('.offcanvas-menu-wrap').removeClass('sidebar-open');
		$('.offcanvas-overlay').removeClass('overlay-open');
	})
	// 05. Data-Background Js
	$("[data-background").each(function () {
		$(this).css("background-image", "url( " + $(this).attr("data-background") + "  )");
	});
	/* 
	-----------------------------
	Aos JQUERY PLUGIN
	-----------------------------
	
	*/
	$('.demo').lightcase();
	new WOW().init();
	/* 

	-----------------------------
	SLICK ACTIVATION BLOG HOMEPAGE ONE
	-----------------------------
	
	*/
	//blog single active
	var $singleblog = $('.blog_single_active');
	if ($singleblog.length > 0) {
		$singleblog.slick({
			dots: false,
			arrows: true,
			infinite: true,
			prevArrow: '<button class="prev-arrow-blog"><i class="fas fa-chevron-left"></i></button>',
			nextArrow: '<button class="next-arrow-blog"><i class="fas fa-chevron-right"></i></button>',
			speed: 300,
			slidesToShow: 3,
			slidesToScroll: 3,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}
	//instagram activition
	var $instagram = $('.active-instagram');
	if ($instagram.length > 0) {
		$instagram.slick({
			dots: false,
			arrows: false,
			infinite: true,
			speed: 300,
			slidesToShow: 4,
			slidesToScroll: 1,
			centerMode: true,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}

	//magnifi popup
	$('.video-open').magnificPopup({
		type: 'iframe'
	});
	//tips slider active
	//magnifi popup
	$('.insta').magnificPopup({
		type: 'image'
	});
	//tips slider active

	var $tips = $('.tips-slider-active');
	if ($tips.length > 0) {
		$tips.slick({
			dots: false,
			arrows: true,
			infinite: true,
			prevArrow: '<button class="tipsbtn prev-arrow-tips"><i class="fas fa-chevron-left"></i></button>',
			nextArrow: '<button class="tipsbtn next-arrow-tips"><i class="fas fa-chevron-right"></i></button>',
			speed: 300,
			slidesToShow: 3,
			slidesToScroll: 2,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}

	var $blogHome = $('.blogHome-active');
	if ($blogHome.length > 0) {
		$blogHome.slick({
			dots: false,
			arrows: true,
			infinite: true,
			prevArrow: '<button class="tipsbtn prev-arrow-tips bloghomearrow"><i class="fas fa-chevron-left"></i></button>',
			nextArrow: '<button class="tipsbtn next-arrow-tips bloghomearrow"><i class="fas fa-chevron-right"></i></button>',
			speed: 300,
			slidesToShow: 3,
			slidesToScroll: 2,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}
	var $blogdetailspost = $('.post-details-active');
	if ($blogdetailspost.length > 0) {
		$blogdetailspost.slick({
			dots: false,
			arrows: true,
			infinite: true,
			prevArrow: '<button class="tipsbtn prev-arrow-tips bloghomearrow blog-details-prev"><i class="fas fa-chevron-left"></i></button>',
			nextArrow: '<button class="tipsbtn next-arrow-tips bloghomearrow blog-details-next"><i class="fas fa-chevron-right"></i></button>',
			speed: 300,
			slidesToShow: 2,
			slidesToScroll: 1,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}

	var $blogdetailsposttwo = $('.post-details-active-2');
	if ($blogdetailsposttwo.length > 0) {
		$blogdetailsposttwo.slick({
			dots: false,
			arrows: true,
			infinite: true,
			prevArrow: '<button class="tipsbtn prev-arrow-tips bloghomearrow blog-details-prev"><i class="fas fa-chevron-left"></i></button>',
			nextArrow: '<button class="tipsbtn next-arrow-tips bloghomearrow blog-details-next"><i class="fas fa-chevron-right"></i></button>',
			speed: 300,
			slidesToShow: 3,
			slidesToScroll: 1,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}
	var $members = $('.members-slider-active');
	if ($members.length > 0) {
		$members.slick({
			dots: true,
			arrows: false,
			infinite: true,
			speed: 300,
			slidesToShow: 3,
			slidesToScroll: 1,
			responsive: [{
					breakpoint: 1024,
					settings: {
						slidesToShow: 2,
						slidesToScroll: 2,
					}
				},
				{
					breakpoint: 600,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				},
				{
					breakpoint: 480,
					settings: {
						slidesToShow: 1,
						slidesToScroll: 1,
					}
				}
			]
		});
	}


	// Sticky Header Js

	$(window).on('scroll', function () {

		var scroll = $(window).scrollTop();

		if (scroll < 245) {

			$("#header-sticky").removeClass("sticky-bar");

		} else {

			$("#header-sticky").addClass("sticky-bar");

		}

	});

	$('.hero-slider-item').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		arrows: false,
		fade: true,
		asNavFor: '.slider-nav',
		autoplay: true
	});
	$('.slider-nav').slick({
		slidesToShow: 1,
		slidesToScroll: 1,
		asNavFor: '.hero-slider-item',
		dots: false,
		centerMode: false,
		focusOnSelect: true,
		prevArrow: '<button class="tipsbtn prev-arrow-tips slider-hero"><i class="fas fa-chevron-left"></i></button>',
		nextArrow: '<button class="tipsbtn next-arrow-tips slider-hero"><i class="fas fa-chevron-right"></i></button>',

	});


})(jQuery);