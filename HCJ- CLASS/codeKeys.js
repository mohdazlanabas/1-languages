//KEYS
//const circle = document.querySelector('.bally')
//function control(e){
//    if (e.key === 37){
//        console.log('pressed left')
//}   else if (e.key === 39){
//        console.log('pressed right')
//}   else if (e.key === 38){
  //      console.log('pressed up')
//}   else if (e.key === 40){
//    console.log('pressed down'}}
//document.addEventListener ('keydown', control)

const circle = document.querySelector('.ballg')
letxAxis = 0
letyAxis = 0

function control(e){
switch (e.key){
  case "ArrowLeft":
    console.log('pressed left')
    xAxis -= 50
    console.log(xAxis)
    circle.style.left = xAxis + 'px'
    break
  case "ArrowRight":
    console.log('pressed right')
    xAxis += 50
    console.log(xAxis)
    circle.style.left = xAxis + 'px'
    break
  case "ArrowUp":
    console.log('pressed up')
    yAxis -= 50
    circle.style.top = yAxis + 'px'
    break
  case "ArrowDown":
    console.log('pressed down')
    yAxis += 50
    circle.style.top = yAxis + 'px'
    break
  default:
    console.log('Key Not Recogmized')
}}
document.addEventListener('keydown, control')