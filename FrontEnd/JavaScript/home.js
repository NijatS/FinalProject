var imgs = document.querySelectorAll(".slider img");
var dots = document.querySelectorAll(".dot");
const coruselElements = document.querySelectorAll(".carusel-item");
const carusel = document.querySelector(".carusel");
var currentImg = 0;
const interval = 3000;
var i = 0;
let x = 0;
// var timer = setInterval(changeSlide(i), interval);
setInterval(changeCarusel(), 1000);
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
function changeCarusel() {
  if (coruselElements.length > 6) {
    let count = coruselElements.length - 6;
    console.log(carusel);
    if (i < count) {
      x = x - 190;
      console.log("a");
      i++;
    } else if (i == count) {
      x = 0;
      console.log("b");
      i = 0;
    }
    carusel.style.transform = `translate3d(${x}px, 0px, 0px)`;
  }
}
