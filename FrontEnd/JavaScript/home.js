var imgs = document.querySelectorAll(".slider img");
var dots = document.querySelectorAll(".dot");
var currentImg = 0; // index of the first image
const interval = 3000; // duration(speed) of the slide
var i = 0;
// var timer = setInterval(changeSlide(i), interval);
currentImg = (currentImg + 1) % imgs.length; // update the index number

function changeSlide(n) {
  for (var i = 0; i < imgs.length; i++) {
    // reset
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
