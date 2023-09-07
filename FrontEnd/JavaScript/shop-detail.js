const sImages = document.querySelectorAll(".sliders >ol img");
const lImages = document.querySelectorAll(".viewport a>img");
const slideContainer = document.querySelector(".slides");
const slideElements = document.querySelectorAll(".slides>li");
const decreaseBtn = document.querySelector(".nav-prev");
const increaseBtn = document.querySelector(".nav-next");
const sections = document.querySelectorAll(".tabs>ul li");
const infos = document.querySelectorAll(".info");
const time = document.querySelector(
  ".car-detail .col-md-4 .infoCar  li:first-child"
);
const bidButton = document.querySelector("#bidButton");
const FULL_DASH_ARRAY = 283;
const WARNING_THRESHOLD = 10;
const ALERT_THRESHOLD = 5;
let i = 0;
setInterval(timeCalculate, 1000);
const decreaseBit = document.querySelector(".buttons button:first-child");
const increaseBit = document.querySelector(".buttons button:last-child");
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
decreaseBit.addEventListener("click", () => {
  let number =
    parseInt(
      document.querySelector(".bid input").value.split("$")[1].replace(",", "")
    ) - 500;
  if (
    number - 500 <
    document
      .querySelector("#base-timer-bid")
      .textContent.split("$")[1]
      .replace(",", "")
  ) {
    return;
  }
  const format = number.toLocaleString("en-US");
  let text = "$" + format;
  document.querySelector(".bid input").value = text;
});
increaseBit.addEventListener("click", () => {
  increase();
});
bidButton.addEventListener("click", () => {
  document.querySelector("#base-timer-bid").textContent =
    document.querySelector(".bid input").value;
  increase();
  document.querySelector(".base-timer__path-remaining ").style.transition =
    "none";
  timePassed = -1;
  timeLeft = TIME_LIMIT;
  document
    .getElementById("base-timer-path-remaining")
    .classList.add(`${remainingPathColor}`);
  format();
  playClick();
});
function timeCalculate() {
  if (time.textContent.split(":")[1] == "0D 0H 0min") {
    i++;
    enquiry.children[0].querySelector("h4").textContent = "Live Auction";
    enquiry.style.margin = "0";
    enquiry.children[1].style.display = "none";
    enquiry.children[enquiry.children.length - 1].style.display = "none";
    enquiry.parentElement.style.flexDirection = "column-reverse";
    enquiry.parentElement.style.alignSelf = "flex-start";
    enquiry.parentElement.style.gap = "30px";
    if (i == 1) {
      startTimer();
      document.querySelector(".bid input").value =
        "$" +
        (
          parseInt(
            document
              .querySelector("#base-timer-bid")
              .textContent.split("$")[1]
              .replace(",", "")
          ) + 500
        ).toLocaleString("en-US");
    }
  }
}
const enquiry = document.querySelector(".enquiry");
const circle = document.querySelector(".circle");
const TIME_LIMIT = 10;
let timePassed = 0;
let timeLeft = TIME_LIMIT;
let timerInterval = null;

const COLOR_CODES = {
  info: {
    color: "green",
  },
  warning: {
    color: "orange",
    threshold: WARNING_THRESHOLD,
  },
  alert: {
    color: "red",
    threshold: ALERT_THRESHOLD,
  },
};
let remainingPathColor = COLOR_CODES.info.color;

circle.innerHTML = `<div class="base-timer">
<svg class="base-timer__svg" viewBox="0 0 100 100" xmlns="http://www.w3.org/2000/svg">
  <g class="base-timer__circle">
    <circle class="base-timer__path-elapsed" cx="50" cy="50" r="45"></circle>
    <path
      id="base-timer-path-remaining"
      stroke-dasharray="283"
      class="base-timer__path-remaining ${remainingPathColor}"
      d="
        M 50, 50
        m -45, 0
        a 45,45 0 1,0 90,0
        a 45,45 0 1,0 -90,0
      "
    ></path>
  </g>
</svg>
<span id="base-timer-label" class="base-timer__label" style="display:none">${formatTime(
  timeLeft
)}</span>
<div id = "base-timer-div">
<span id="base-timer-flag"><img src="../Images/azerbaijan.png"></span>
<span id="base-timer-country">Azerbaijan</span>
<span id="base-timer-bid">$22,000</span>
<span id="base-timer-word">Bid</span>
</div>
<div id = "sold-on">
<span>Sold On Approval!</span>
</div>
<div id = "win">
<span>Congratulation</span>
<span>You Win!</span>
</div>
</div>`;
function calculateTimeFraction() {
  const rawTimeFraction = timeLeft / TIME_LIMIT;
  return rawTimeFraction - (1 / TIME_LIMIT) * (1 - rawTimeFraction);
}
function onTimesUp() {
  clearInterval(timerInterval);
  document.querySelector("#base-timer-div").style.display = "none";
  document.querySelector(".bid").style.display = "none";
  if (true) {
    document.querySelector("#win").style.display = "flex";
    document.getElementById("base-timer-path-remaining").style.color = "green";
    document.querySelector(".base-timer__circle").style.fill = "green";
  } else {
    document.querySelector("#sold-on").style.display = "flex";
    document.getElementById("base-timer-path-remaining").style.color = "blue";
    document.querySelector(".base-timer__circle").style.fill = "blue";
  }
  let myAudio = document.querySelector("#audioWin");
  myAudio.play();
}
function setCircleDasharray() {
  const circleDasharray = `${(
    calculateTimeFraction() * FULL_DASH_ARRAY
  ).toFixed(0)} 283`;
  document
    .getElementById("base-timer-path-remaining")
    .setAttribute("stroke-dasharray", circleDasharray);
}
function setRemainingPathColor(timeLeft) {
  const { alert, warning, info } = COLOR_CODES;
  if (timeLeft <= alert.threshold) {
    document
      .getElementById("base-timer-path-remaining")
      .classList.remove(warning.color);
    document
      .getElementById("base-timer-path-remaining")
      .classList.add(alert.color);
  } else if (timeLeft <= warning.threshold) {
    document
      .getElementById("base-timer-path-remaining")
      .classList.remove(info.color);
    document
      .getElementById("base-timer-path-remaining")
      .classList.add(warning.color);
  }
}
function formatTime(time) {
  const minutes = Math.floor(time / 60);
  let seconds = time % 60;

  if (seconds < 10) {
    seconds = `0${seconds}`;
  }

  return `${minutes}:${seconds}`;
}
function startTimer() {
  timerInterval = setInterval(() => {
    timePassed += 0;
    timeLeft = TIME_LIMIT - timePassed;
    document.getElementById("base-timer-label").innerHTML =
      formatTime(timeLeft);
    setCircleDasharray();
    setRemainingPathColor(timeLeft);
    if (timeLeft === 0) {
      onTimesUp();
    }
  }, 1000);
}
function playClick() {
  let myAudio = document.querySelector("#audio");
  myAudio.play();
}
function increase() {
  let number =
    parseInt(
      document.querySelector(".bid input").value.split("$")[1].replace(",", "")
    ) + 500;

  const format = number.toLocaleString("en-US");
  let text = "$" + format;
  document.querySelector(".bid input").value = text;
}
function format() {
  document.querySelector(".base-timer__path-remaining ").style.transition =
    "1s linear all";
}
