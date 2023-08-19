const coruselItem = document.querySelectorAll(".user-carusel-item");
const container = document.querySelector(".user-carusel-container");
const back = document.querySelector(".back");
const next = document.querySelector(".next");
const teamMembers = document.querySelectorAll(".team-member img");
let k = 0;
let currentSize = 0;
setInterval(getSize, 100);
setInterval(changeCarusel, 4000, true);
teamMembers.forEach((member) => {
  member.style.transition = "1s";
  member.addEventListener("pointerenter", (e) => {
    const social = member.parentElement.querySelector(".socials");
    e.preventDefault();
    social.style.opacity = 1;
    social.style.visibility = "visible";
    social.addEventListener("pointerenter", (e) => {
      e.preventDefault();
      social.style.opacity = 1;
      social.style.visibility = "visible";
    });
  });
  member.addEventListener("pointerleave", () => {
    const social = member.parentElement.querySelector(".socials");
    social.style.opacity = 0;
    social.style.visibility = "hidden";
  });
  member.parentElement.addEventListener("pointerout", (e) => {
    const social = member.parentElement.querySelector(".socials");
    social.style.opacity = 0;
    social.style.visibility = "hidden";
  });
});

next.addEventListener("click", () => {
  style = getComputedStyle(container);
  size = style.transform;
  changeCarusel(true);
});
back.addEventListener("click", () => {
  style = getComputedStyle(container);
  size = style.transform;
  changeCarusel(false);
});
function getSize() {
  var width = window.innerWidth;
  if (width < 992) {
    coruselItem.forEach((item) => {
      item.style.width = `${width - 30}px`;
    });
  } else {
    coruselItem.forEach((item) => {
      item.style.width = `1140px`;
    });
  }
}
function changeCarusel(status) {
  if (k < coruselItem.length - 1) {
    var width = window.innerWidth;
    if (width < 992) {
      if (status) {
        currentSize += width - 30;
      } else {
        currentSize -= width - 30;
      }
      container.style.transform = `translate3d(-${currentSize}px, 0px, 0px)`;
    } else {
      if (status) {
        currentSize += 1140;
      } else {
        currentSize -= 1140;
      }
      container.style.transform = `translate3d(-${currentSize}px, 0px, 0px)`;
    }
    k++;
  } else {
    k = 0;
    currentSize = 0;
    container.style.transform = `translate3d(0px, 0px, 0px)`;
  }
}
