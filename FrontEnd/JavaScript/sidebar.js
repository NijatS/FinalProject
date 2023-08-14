const sideBarButton = document.querySelector(".side-menu-button");
const sidebarMenu = document.querySelector(".sidebar-menu");
const sidebarContainer = document.querySelector(".sidebar-menu-container");
const sidebarMenuPush = document.querySelector(".sidebar-menu-push");
const sidebarMenuOverlay = document.querySelector(".sidebar-menu-overlay");
const searchBtn = document.querySelector("#search-item .fa-search");
const closeBtn = document.querySelector("#search-item .fa-close");
const example = document.querySelector(".example");
sideBarButton.addEventListener("click", (e) => {
  sidebarMenu.style.left = "0px";
  sidebarMenuPush.style.transform = "translate3d(300px, 0, 0)";
  sidebarMenuOverlay.style.display = "initial";
  e.stopPropagation();
  sidebarContainer.addEventListener("click", () => {
    sidebarMenu.style.left = "-300px";
    sidebarMenuPush.style.transform = "translate3d(0px, 0, 0)";
    sidebarMenuOverlay.style.display = "none";
  });
});
searchBtn.addEventListener("click", () => {
  searchBtn.parentElement.style.display = "none";
  example.style.display = "block";
});
closeBtn.addEventListener("click", () => {
  searchBtn.parentElement.style.display = "block";
  example.style.display = "none";
});
