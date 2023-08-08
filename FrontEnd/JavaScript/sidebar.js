const sideBarButton = document.querySelector(".side-menu-button");
const sidebarMenu = document.querySelector(".sidebar-menu");
const sidebarContainer = document.querySelector(".sidebar-menu-container");
const sidebarMenuPush = document.querySelector(".sidebar-menu-push");
const sidebarMenuOverlay = document.querySelector(".sidebar-menu-overlay");
sideBarButton.addEventListener("click", (e) => {
  sidebarMenu.style.left = "0px";
  sidebarMenuPush.style.transform = "translate3d(320px, 0, 0)";
  sidebarMenuOverlay.style.display = "initial";
  e.stopPropagation();
  sidebarContainer.addEventListener("click", () => {
    sidebarMenu.style.left = "-250px";
    sidebarMenuPush.style.transform = "translate3d(0px, 0, 0)";
    sidebarMenuOverlay.style.display = "none";
  });
});
