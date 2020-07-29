"use strict"
let loginInputs = document.querySelectorAll('.form-input-holder input');
let submitInput = document.querySelector('form .login')
let images = document.querySelectorAll('.left-side img')
function changeParagraph(e) {
    if (e.value != "") {
        e.parentElement.classList.add("active");
    }
    else {
        e.parentElement.classList.remove("active")
    }
    if (loginInputs[0].value.length > 4 && loginInputs[1].value.length > 7) {
        submitInput.disabled = false
    }
    else {
        submitInput.disabled = true
    }
}

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
