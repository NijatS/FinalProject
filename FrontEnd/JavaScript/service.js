const counts = document.querySelectorAll(".fact-count");
let i = 0;

counts.forEach((count) => {
  setInterval(increase, 1, count);
});

function increase(element) {
  if (i < element.ariaValueNow) {
    i = i + 30;
    art(element, i);
  } else {
    art(element, element.ariaValueNow);
  }
}
function art(element, i) {
  element.textContent = `${i}`;
}
