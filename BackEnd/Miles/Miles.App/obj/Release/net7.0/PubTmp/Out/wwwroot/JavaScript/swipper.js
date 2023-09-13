const swiper = new Swiper('.sample-slider', {
    loop: true,
    speed: 2000,
    slidesPerView: 3,
    autoplay: {
        delay: 0,
    },
})
swiper.el.addEventListener('mouseover', function () {
    swiper.autoplay.stop();
})
swiper.el.addEventListener('mouseleave', function () {
    swiper.autoplay.start();
})