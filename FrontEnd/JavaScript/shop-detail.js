const sImages = document.querySelectorAll(".sliders >ol img");
const lImages = document.querySelectorAll(".viewport a>img");
const slideContainer = document.querySelector(".slides");
const slideElements = document.querySelectorAll(".slides>li");
const decreaseBtn = document.querySelector(".nav-prev");
const increaseBtn = document.querySelector(".nav-next");
sImages[0].style.opacity = "1";
for (let i = 0; i < sImages.length; i++) {
  sImages[i].addEventListener("click", () => {
    style = getComputedStyle(slideElements[0]);
    size = style.width;
    size = parseInt(size, 10);
    slideContainer.style.transform = `translate3d(-${size * i}px, 0px, 0px)`;
    sImages.forEach((imageBlur) => {
      imageBlur.style.opacity = "0.5";
    });
    sImages[i].style.opacity = "1";
    lImages.forEach((image1) => {
      if (sImages[i].getAttribute("src") == image1.getAttribute("src")) {
      }
    });
  });
}
decreaseBtn.addEventListener("click", () => {
  for (let i = 0; i < sImages.length; i++) {
    if (sImages[i].style.opacity == "1") {
      style = getComputedStyle(slideElements[0]);
      size = style.width;
      size = parseInt(size, 10);
      sImages[i].style.opacity = "0.5";
      if (i == 0) {
        sImages[sImages.length - 1].style.opacity = "1";
        let value = size * (sImages.length - 1);
        slideContainer.style.transform = `translate3d(-${value}px, 0px, 0px)`;
      } else {
        sImages[i - 1].style.opacity = "1";
        slideContainer.style.transform = `translate3d(-${
          size * (i - 1)
        }px, 0px, 0px)`;
      }
      break;
    }
  }
});
increaseBtn.addEventListener("click", () => {
  for (let i = 0; i < sImages.length; i++) {
    if (sImages[i].style.opacity == "1") {
      style = getComputedStyle(slideElements[0]);
      size = style.width;
      size = parseInt(size, 10);
      sImages[i].style.opacity = "0.5";
      if (i == sImages.length - 1) {
        sImages[0].style.opacity = "1";
        let value = size * (i - sImages.length + 1);
        slideContainer.style.transform = `translate3d(${value}px, 0px, 0px)`;
      } else {
        sImages[i + 1].style.opacity = "1";
        slideContainer.style.transform = `translate3d(-${
          size * (i + 1)
        }px, 0px, 0px)`;
      }
      break;
    }
  }
});
