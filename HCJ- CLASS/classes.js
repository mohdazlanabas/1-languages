//Class
//Class Declaration

//class Rectangle {
//    constructor(height, width){
//        this.height = height
//        this.width = width    }}
//const newRectangle = new Rectangle(300,300)
//console.log(newRectangle.width)

const square = document.createElement('div')
const body = document.querySelector('body')
const image = document.createElement("img")
body.appendChild(square)
body.appendChild(image)

//.setAttrribute
image.setAttribute('src', 'heathcare.jpeg')
image.setAttribute('data-id', 4)

//.getAttribute
const imagePath = image.getAttribute('src')
const imageId = Image.getAttribute('data-id')

console.log(imagePath)
console.log(imageId)
console.log(body)

