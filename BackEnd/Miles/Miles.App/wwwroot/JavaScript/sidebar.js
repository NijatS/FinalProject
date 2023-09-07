const sideBarButton = document.querySelector(".side-menu-button");
const sidebarMenu = document.querySelector(".sidebar-menu");
const sidebarContainer = document.querySelector(".sidebar-menu-container");
const sidebarMenuPush = document.querySelector(".sidebar-menu-push");
const sidebarMenuOverlay = document.querySelector(".sidebar-menu-overlay");
const searchBtn = document.querySelector("#search-item .fa-search");
const closeBtn = document.querySelector("#search-item .fa-close");
const example = document.querySelector(".example");
let INDEX = 0;
var user = null;
let href = `/account/GetUser`;
fetch(href)
    .then(x => x.json())
    .then(x => {
        if (x != null) {
            user = x;
        }
    })

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
document.querySelector("#chat-submit").addEventListener("click", (e) => {
    e.preventDefault();
       var msg = $("#chat-input").val();
        if (msg.trim() == '') {
            return false;
    }
    let href = `/home/SendMessageBot?message=${msg}`;
    generate_message(msg, 'self');
    fetch(href)
           .then(x => x.json())
           .then(x => {
               var buttons = [
            {
                name: 'Existing User',
                value: 'existing'
            },
            {
                name: 'New User',
                value: 'new'
            }
        ];
               setTimeout(function () {
                   generate_message(x, 'user');
               }, 1000)
           })
 


})

    function generate_message(msg, type) {
        INDEX++;
        var str = "";
        str += "<div id='cm-msg-" + INDEX + "' class=\"chat-msg " + type + "\">";
        str += "          <span class=\"msg-avatar\">";
        if (type == 'self') {
            if (user == null) {
                str += "            <img src=\"https://localhost:7109/Images/Users/User-avatar.svg.png\">";

            }
            else {
                str += `            <img src=\"https://localhost:7109/Images/Users/${user.image}\">`;

            }
        }
        else {
            str += "            <img src=\"https://localhost:7109/Images/Users/admin.jpg\">";

        }
        str += "          <\/span>";
        str += "          <div class=\"cm-msg-text\">";
        str += msg;
        str += "          <\/div>";
        str += "        <\/div>";
        $(".chat-logs").append(str);
        $("#cm-msg-" + INDEX).hide().fadeIn(300);
        if (type == 'self') {
            $("#chat-input").val('');
        }
        $(".chat-logs").stop().animate({ scrollTop: $(".chat-logs")[0].scrollHeight }, 1000);
    }

    function generate_button_message(msg, buttons) {
        /* Buttons should be object array 
          [
            {
              name: 'Existing User',
              value: 'existing'
            },
            {
              name: 'New User',
              value: 'new'
            }
          ]
        */
        INDEX++;
        var btn_obj = buttons.map(function (button) {
            return "              <li class=\"button\"><a href=\"javascript:;\" class=\"btn btn-primary chat-btn\" chat-value=\"" + button.value + "\">" + button.name + "<\/a><\/li>";
        }).join('');
        var str = "";
        str += "<div id='cm-msg-" + INDEX + "' class=\"chat-msg user\">";
        str += "          <span class=\"msg-avatar\">";
        str += "            <img src=\"https:\/\/image.crisp.im\/avatar\/operator\/196af8cc-f6ad-4ef7-afd1-c45d5231387c\/240\/?1483361727745\">";
        str += "          <\/span>";
        str += "          <div class=\"cm-msg-text\">";
        str += msg;
        str += "          <\/div>";
        str += "          <div class=\"cm-msg-button\">";
        str += "            <ul>";
        str += btn_obj;
        str += "            <\/ul>";
        str += "          <\/div>";
        str += "        <\/div>";
        $(".chat-logs").append(str);
        $("#cm-msg-" + INDEX).hide().fadeIn(300);
        $(".chat-logs").stop().animate({ scrollTop: $(".chat-logs")[0].scrollHeight }, 1000);
        $("#chat-input").attr("disabled", true);
    }

    $(document).delegate(".chat-btn", "click", function () {
        var value = $(this).attr("chat-value");
        var name = $(this).html();
        $("#chat-input").attr("disabled", false);
        generate_message(name, 'self');
    })

    $("#chat-circle").click(function () {
        $("#chat-circle").toggle('scale');
        $(".chat-box").toggle('scale');
    })

    $(".chat-box-toggle").click(function () {
        $("#chat-circle").toggle('scale');
        $(".chat-box").toggle('scale');
    })

//})

window.onscroll = function () { scrollFunction() };

function scrollFunction() {
    if (document.body.scrollTop > 20 || document.documentElement.scrollTop > 20) {
        document.querySelector(".to-top-button").style.display = "block";
    } else {
        document.querySelector(".to-top-button").style.display = "none";
    }
}
document.querySelector(".to-top-button").addEventListener("click", () => {
    window.scroll({
        top: 0,
        left: 0,
        behavior: 'smooth'
    });
})
