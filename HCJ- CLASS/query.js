//.addEventListener()
//target.addEventListener(event, function)

//const Yellow = document.getElementsByClassName("ballYellow")
//function alertMe() {
//  console.log('clicked')}
//Yellow.addEventListener('click', alertMe)

//const body = document.querySelector('body')
//body.addEventListener('click', function () {
//    console.log('clicked)')})

//remove EventListener
//let count = 0
//function toggleColor(){
//    circle.classList.toggle('ballBlack')
//    count++
//    console.log (count)
//    if (count > 10) {
//        circle.renoveEventListener('click', toggleColor)}}
//circle.addEventListener('click', toggleColor)

//const circle = document.querySelector('.ballYellow')
//let height = 0
//function moveCircle(){
//    height += 100
//    circle.style.top = height + 'px'
//    if (height > 300) {
//        circle.removeEventListener('click', moveCircle)}}
//circle.addEventListener('click', moveCircle)

//Query Selector
const circle = document.querySelectorAll("#one")
console.log(circle)