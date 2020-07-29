"use strict"
let loginInputs = document.querySelectorAll('.form-input-holder input');
let loginBtnHolder = document.querySelector('form .login-button-holder')
let loginBtn = document.querySelector('form .login-button-holder input')
let images = document.querySelectorAll('.left-side img')
function changeParagraph(e) {
    if (e.value != "") {
        e.parentElement.classList.add("active");
    }
    else {
        e.parentElement.classList.remove("active")
    }
}
function toggleDisabled(params) {
    if (loginInputs[0].value.length >= 4 && loginInputs[1].value.length >= 7) {
        loginBtnHolder.classList.remove("disabled")
    }
    else {
        loginBtnHolder.classList.add("disabled")
    }
}
loginBtn.addEventListener("click", function () {
    loginBtn.classList.add("d-none")
    loginBtn.nextElementSibling.classList.remove("d-none")
})
let activeImg;
let timer = setInterval(() => {
    images.forEach(image => {
        if (image.classList.contains("active")) {
            activeImg = image
        }
    }
)}, 2000)
let intervalForImages = setInterval(() => {
    images.forEach(image => {
        if (image.classList.contains("active")) {
            activeImg = image
        }
    });
    if (activeImg.nextElementSibling) {
        activeImg.classList.remove("active")
        activeImg.nextElementSibling.classList.add("active")
    }
    else{
        activeImg.classList.remove("active")
        images[0].classList.add("active")
    }
}, 4000);
