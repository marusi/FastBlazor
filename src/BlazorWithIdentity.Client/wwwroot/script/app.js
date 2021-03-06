$(function () {

  // On mouse click and touch, add a class to <button> and <a> that removes focus rectangle
  $(document).on('mousedown touchstart', 'a, button', function () {
    $('.no-outline').removeClass('no-outline');
    $(this).addClass('no-outline');
  });

  // On keyboard navigation, remove the class that hides focus rectangle
  $(document).on('keydown', function (e) {
    var keyCode = e.keyCode || e.which;
    var tabKeyCode = 9;

    if (keyCode === tabKeyCode) {
      $('.no-outline').removeClass('no-outline');
    }
  });

  //
  // Side Nav Large
  //



  // Alert stack


  $(function () {
    var alertStack = $('.alert-stack');

    if (alertStack.length === 0) {
      return;
    }

    alertStack.affix({
      offset: {
        top: alertStack.offset().top
      }
    });
  });

// add-cart
(function () {
  var addProduct = $('.add-product'),
    threshold = 0.001 * $(window).height();

  // Displayed when we've scrolled 2x the viewport height
  if (addProduct.length === 0 ||
    $(document).height() < threshold) {
    return;
  }

  addProduct.affix({
    offset: {
      top: threshold
    }
  });

  // Smooth scroll to top
  addProduct.on('click', function () {
    $('html, body').animate({ scrollTop: 0 }, {
      duration: 750,
      easing: 'swing'
    });

    return ; // prevent default href
  });


})();







  // Back to top
  (function () {
    var backToTop = $('.back-to-top'),
      threshold = 2 * $(window).height();

    // Displayed when we've scrolled 2x the viewport height
    if (backToTop.length === 0 ||
      $(document).height() < threshold) {
      return;
    }

    backToTop.affix({
      offset: {
        top: threshold
      }
    });

    // Smooth scroll to top
    backToTop.on('click', function () {
      $('html, body').animate({ scrollTop: 0 }, {
        duration: 750,
        easing: 'swing'
      });

      return false; // prevent default href
    });
  })();


  // Smooth scroll with page header links
  (function () {
    $("[data-scroll='smooth'] a[href*='#']:not([href='#'])").on('click', function () {
      if (location.pathname.replace(/^\//, '') === this.pathname.replace(/^\//, '') &&
        location.hostname === this.hostname) {

        var target = $(this.hash);
        target = target.length ? target : $('[name=' + this.hash.slice(1) + ']');

        if (target.length) {
          $('html, body').animate({
            scrollTop: target.offset().top
          }, 1500);

          return false; // prevent default href
        }
      }
    });
  })();


  // Forms
  (function () {
    $(".checkbox-indeterminate").prop("indeterminate", true);
  })();


  // Star rating
  (function () {
    $('.rating-btn').on('mouseenter', function () {
      var active = $(this);

      // Highlight the hovered star and the previous stars
      $(this).prevAll('.rating-btn').addClass('active');
      $(this).addClass('active');

      // Remove highlighting of the following stars
      $(this).nextAll('.rating-btn').removeClass('active');
    });

    // Remove highlight of all stars when leaving the container
    $('.rating-stars-input').on('mouseleave', function () {
      $(this).find('.rating-btn').removeClass('active');
    });
  })();


 

  // Flyouts
  // Provide data-theme attribute to set flyout's color theme.
  $('[data-toggle="popover"]').each(function () {
    var $element = $(this);

    $element.popover({
      // Override Bootsrap's default template with one that does not have arrow and title
      template: '<div class="popover" role="tooltip"><div class="popover-content"></div></div>'
    }).data('bs.popover').tip().addClass($element.data("theme"));
  });

  if ($('#btn-close').length) {
    $('#btn-close').popover({
      placement: 'right',
      html: 'true',
      // Set the value of the data-theme attribute as a class name on the button.
      // That way the button will always be in the correct color theme.
      content: 'This is a flyout with a button. <button type="button" class="btn btn-primary ' + $('#btn-close').data("theme") + '"onclick="$(&quot;#btn-close&quot;).popover(&quot;hide&quot;);">Button</button>',
      template: '<div class="popover" role="tooltip"><div class="popover-content"></div></div>'
    }).data('bs.popover').tip().addClass($('#btn-close').data("theme"));
  }

  // Entity list item
  $('.entity-list-expandable .entity-list-item').click(function () {
    if ($(this).hasClass('active') === false) {
      var parent = $(this).parent();
      $('.entity-list-item', parent).removeClass('active');
      $(this).addClass('active');

    }
  });
});


