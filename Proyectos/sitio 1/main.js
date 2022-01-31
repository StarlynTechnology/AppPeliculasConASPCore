

// Show Nav Bar

const nav = document.querySelector('.nav-menu');
const toggle = document.querySelector('.nav-toggle');

toggle.onclick = function(){
    nav.classList.toggle('show-nav')
}

// Remove Menu Bar

const navLink = document.querySelectorAll('.nav-link');
const closeToggle = document.querySelectorAll('.close');

function linkAction(){
    const navMenu = document.querySelector('.nav-menu');
    navMenu.classList.remove('show-nav')
}
navLink.forEach(n => n.addEventListener('click', linkAction));
closeToggle.forEach(n => n.addEventListener('click', linkAction));

// Active Link 

const linkColor = document.querySelectorAll('.nav-link');
function colorLink(){
    if(linkColor){
        linkColor.forEach(L => L.classList.remove('active'))
        this.classList.add('active')
    }
}
linkColor.forEach(L => L.addEventListener('click', colorLink))