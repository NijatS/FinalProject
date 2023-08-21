const swiper = new Swiper(".book-swiper", {
    slidesPerView: 2,
    spaceBetween: 10,
    loop: true,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    autoplay: {
        delay: 1000,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
});

const swiperCompany = new Swiper(".brand-swiper", {
    // slidesPerView: 4,
    spaceBetween: 10,
    loop: true,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    autoplay: {
        delay: 1000,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    breakpoints: {
        // when window width is >= 320px
        320: {
            slidesPerView: 1,
            spaceBetween: 20,
        },

        565: {
            slidesPerView: 2,
            spaceBetween: 20,
        },
        // when window width is >= 480px
        768: {
            slidesPerView: 3,
            spaceBetween: 30,
        },
        // when window width is >= 640px
        1024: {
            slidesPerView: 4,
            spaceBetween: 40,
        },
    },
});

const feedback = new Swiper(".feedback-swiper", {
    slidesPerView: 1,
    loop: true,

    // spaceBetween: 10,
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
    autoplay: {
        delay: 1000,
        disableOnInteraction: false,
    },
    pagination: {
        el: ".swiper-pagination",
        clickable: true,
    },
});

 var feedback = new Swiper(".feedback-swiper", {});