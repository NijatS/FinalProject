const commentBtn = document.querySelector("#commentBtn");
commentBtn.addEventListener("click", (e) => {
    e.preventDefault();
    let subject = document.querySelector(".subjectComment").value;
    let text = document.querySelector(".textComment").value;
    let blogId = document.querySelector(".blogComment").value;
    let href = `/blog/PostComment?text=${text}&subject=${subject}&blogId=${blogId}&carId=0`;
    fetch(href)
        .then(x => x.json())
        .then(x => {
            if (x.statusCode == 200) {
                var currentDate = new Date();
                currentDate = currentDate.toLocaleDateString('en-US');
                let comment = ` <div class="comment">
                            <img src="/Images/Users/${x.comment.appUser.image}"/>
                            <div >
                                <div class="comment-info">
                                        <h4>${x.comment.appUser.name} ${x.comment.appUser.surname}</h4>
                                        <span>${currentDate}</span>
                                </div>
                                <span>${x.comment.subject}</span>
                                    <span>${x.comment.text}</span>
                            </div>
                        </div>`;
                document.querySelector(".empty").innerHTML += comment;
                document.querySelector(".subjectComment").value = "";
                document.querySelector(".textComment").value = "";
            }
            else if (x.statusCode == 404) {
                location.replace("/account/Login");
            }
            else {
                    Swal.fire({
                        icon: 'error',
                        title: 'Oops...',
                        text: `${x.desc}`,
                    })
            }
        })
})
var fbButton = document.querySelector('.author a');
var url = window.location.href;

fbButton.addEventListener('click', function () {
    window.open('https://www.facebook.com/sharer/sharer.php?u=' + url,
        'facebook-share-dialog',
        'width=800,height=600'
    );
    return false;
});
