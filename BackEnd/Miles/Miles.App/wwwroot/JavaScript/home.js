const imgs = document.querySelectorAll(".slider img");
const dots = document.querySelectorAll(".dot");
const coruselElements = document.querySelectorAll(".carusel-item");
const carusel = document.querySelector(".carusel");
const clientColumn = document.querySelector(".client-column");
let currentImg = 0;
let i = 0;
let j = 0;
let x = 0;
setInterval(autoSlide, 3000);
currentImg = (currentImg + 1) % imgs.length;

if (coruselElements.length > 6) {
  let count = coruselElements.length - 6;
  setInterval(changeCarusel, 2000, count);
}
function autoSlide() {
  if (j < imgs.length - 1) {
    j++;
    changeSlide(j);
  } else {
    j = 0;
    changeSlide(j);
  }
}
function changeSlide(n) {
  for (var i = 0; i < imgs.length; i++) {
    imgs[i].style.opacity = 0;
    dots[i].className = dots[i].className.replace(" active", "");
  }
  currentImg = n;
  imgs[currentImg].style.opacity = 1;
  dots[currentImg].className += " active";
}
function changeCarusel(count) {
  if (window.screen.width >= 900 && window.screen.width <= 1140) {
    clientColumn.style.width = "900px";
    coruselElements.forEach((element) => {
      element.style.width = "180px";
      count = coruselElements.length - 5;
    });
  } else if (window.screen.width >= 500 && window.screen.width < 900) {
    clientColumn.style.width = "500px";
    coruselElements.forEach((element) => {
      element.style.width = "240px";
      count = coruselElements.length - 2;
    });
  } else {
    clientColumn.style.width = "1140px";
    coruselElements.forEach((element) => {
      element.style.width = "190px";
      count = coruselElements.length - 6;
    });
  }
  style = getComputedStyle(coruselElements[0]);
  size = style.width;
  size = parseInt(size, 10);
  if (i < count) {
    x = x - size;
    i++;
  } else if (i == count) {
    x = 0;
    i = 0;
  }
  carusel.style.transform = `translate3d(${x}px, 0px, 0px)`;
}
