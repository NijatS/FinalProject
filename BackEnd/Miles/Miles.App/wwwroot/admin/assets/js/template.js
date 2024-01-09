(function($) {
  'use strict';
  $(function() {
    var body = $('body');
    var contentWrapper = $('.content-wrapper');
    var scroller = $('.container-scroller');
    var footer = $('.footer');
    var sidebar = $('.sidebar');

    //Add active class to nav-link based on url dynamically
    //Active class can be hard coded directly in html file also as required

    function addActiveClass(element) {
      if (current === "") {
        //for root url
        if (element.attr('href').indexOf("index.html") !== -1) {
          element.parents('.nav-item').last().addClass('active');
          if (element.parents('.sub-menu').length) {
            element.closest('.collapse').addClass('show');
            element.addClass('active');
          }
        }
      } else {
        //for other url
        if (element.attr('href').indexOf(current) !== -1) {
          element.parents('.nav-item').last().addClass('active');
          if (element.parents('.sub-menu').length) {
            element.closest('.collapse')
            element.addClass('active');
          }
          if (element.parents('.submenu-item').length) {
            element.addClass('active');
          }
        }
      }
    }

    var current = location.pathname.split("/").slice(-1)[0].replace(/^\/|\/$/g, '');
    $('.nav li a', sidebar).each(function() {
      var $this = $(this);
      addActiveClass($this);
    })

    //Close other submenu in sidebar on opening any

    sidebar.on('show.bs.collapse', '.collapse', function() {
      sidebar.find('.collapse.show').collapse('hide');
    });


    //Change sidebar

    $('[data-toggle="minimize"]').on("click", function() {
      body.toggleClass('sidebar-icon-only');
    });

    //checkbox and radios
    $(".form-check label,.form-radio label").append('<i class="input-helper"></i>');

    // Remove pro banner on close

   
    //if ($.cookie('majestic-free-banner')!="true") {
    //  document.querySelector('#proBanner').classList.add('d-flex');
    //  document.querySelector('.navbar').classList.remove('fixed-top');
    //}
    //else {
    //  document.querySelector('#proBanner').classList.add('d-none');
    //  document.querySelector('.navbar').classList.add('fixed-top');
    //}
    
    if ($( ".navbar" ).hasClass( "fixed-top" )) {
      document.querySelector('.page-body-wrapper').classList.remove('pt-0');
      document.querySelector('.navbar').classList.remove('pt-5');
    }
    else {
      document.querySelector('.page-body-wrapper').classList.add('pt-0');
      document.querySelector('.navbar').classList.add('pt-5');
      document.querySelector('.navbar').classList.add('mt-3');
      
    }
    //document.querySelector('#bannerClose').addEventListener('click',function() {
    //  document.querySelector('#proBanner').classList.add('d-none');
    //  document.querySelector('#proBanner').classList.remove('d-flex');
    //  document.querySelector('.navbar').classList.remove('pt-5');
    //  document.querySelector('.navbar').classList.add('fixed-top');
    //  document.querySelector('.page-body-wrapper').classList.add('proBanner-padding-top');
    //  document.querySelector('.navbar').classList.remove('mt-3');
    //  var date = new Date();
    //  date.setTime(date.getTime() + 24 * 60 * 60 * 1000); 
    //  $.cookie('majestic-free-banner', "true", { expires: date });
    //});

  });



})(jQuery);
function display() {
    window.print();
}

document.querySelector("#amountCar").textContent ="$"+ parseFloat(document.querySelector("#amountCar").textContent.split("$")[1]).toLocaleString();
document.querySelector("#maxBid").textContent = "$" + parseFloat(document.querySelector("#maxBid").textContent.split("$")[1]).toLocaleString();
document.querySelector(".incomeUser").textContent = "$" + parseFloat(document.querySelector(".incomeUser").textContent.split("$")[1]).toLocaleString();
document.querySelector(".reportBtn").addEventListener("click", () => {
    let date = new Date(document.querySelector(".carSaleDate").value).toLocaleDateString();
    let todate = new Date(document.querySelector(".carSaleToDate").value).toLocaleDateString();
    if (todate == "Invalid Date" && date == "Invalid Date") {
        todate = null
        date = null
    }
    else if (todate == "Invalid Date") {
        todate = null
    }
    else if (date == "Invalid Date") {
        date = null
    }
  
    href = `/admin/home/search?date=${date}&todate=${todate}`;
    fetch(href)
        .then(x => x.json())
        .then(x => {
            document.querySelector(".carsCount").textContent = x.cars.length;
            document.querySelector(".bidsCount").textContent = x.bids.length;
            let count = 0;
            const array = [];
            for (let i = 0; i < x.cars.length; i++) {
                count = count + x.cars[i].auctionWinPrice
            }
            for (let i = 0; i < x.bids.length; i++) {
                array.push(x.bids[i].count)
            }
            let max = Math.max(...array);
            if (max == -Infinity) {
                max=0
            }
            document.querySelector("#maxBid").textContent = "$" + parseFloat(max).toLocaleString();
            document.querySelector("#amountCar").textContent = "$" + parseFloat(count).toLocaleString();
        });
})