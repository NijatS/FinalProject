const sImages = document.querySelectorAll(".sliders >ol img");
const lImages = document.querySelectorAll(".viewport a>img");
const slideContainer = document.querySelector(".slides");
const slideElements = document.querySelectorAll(".slides>li");
const decreaseBtn = document.querySelector(".nav-prev");
const increaseBtn = document.querySelector(".nav-next");
const sections = document.querySelectorAll(".tabs>ul li");
const infos = document.querySelectorAll(".info");
sImages[0].style.opacity = "1";
infos[0].style.display = "block";
sections[0].style.color = "inherit";
sections[0].style.borderBottom = "2px solid #f4c23d";
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
sections.forEach((section) => {
  section.addEventListener("click", () => {
    sections.forEach((sectionAll) => {
      sectionAll.style.color = "#888888";
      sectionAll.style.border = "none";
    });
    section.style.color = "inherit";
    section.style.borderBottom = "2px solid #f4c23d";
    infos.forEach((info) => {
      info.style.display = "none";
      if (
        info.classList.contains(
          section.textContent.trim().toLocaleLowerCase().split(" ")[0]
        )
      ) {
        info.style.display = "block";
      }
    });
  });
});
