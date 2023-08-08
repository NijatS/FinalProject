const imgs = document.querySelectorAll(".slider img");
const dots = document.querySelectorAll(".dot");
const coruselElements = document.querySelectorAll(".carusel-item");
const carusel = document.querySelector(".carusel");
let currentImg = 0;
let i = 0;
let j = 0;
let x = 0;
// var timer = setInterval(changeSlide, 3000, j);
if (coruselElements.length > 6) {
  let count = coruselElements.length - 6;
  setInterval(changeCarusel, 2000, count);
}

currentImg = (currentImg + 1) % imgs.length;

function changeSlide(n) {
  for (var i = 0; i < imgs.length; i++) {
    imgs[i].style.opacity = 0;
    dots[i].className = dots[i].className.replace(" active", "");
  }
  currentImg = n;
  imgs[currentImg].style.opacity = 1;
  dots[currentImg].className += " active";
  if (n != undefined) {
    clearInterval(timer);
    timer = setInterval(changeSlide, interval);
    currentImg = n;
  }
}
function changeCarusel(count) {
  if (i < count) {
    x = x - 190;
    i++;
  } else if (i == count) {
    x = 0;
    i = 0;
  }
  carusel.style.transform = `translate3d(${x}px, 0px, 0px)`;
}
