$(document).ready(function () {
    $('.submit').click(function (event) {
        console.log ('Clciked Button')

        var email = $('.email').val()
        var name = $('.name').val()
        var subject = $('.subject').val()
        var message = $('.message').val()
        var statusElm = $('.status')
        statusElm.empty()

        if(email.length > 5 && email.includes('@') && email.includes('.')) {
            statusElm.append('<div>Email is valid.</div>')
        } else {
            event.preventDefault()
            statusElm.append('<div>Email not typed in correctly.</div>')
        }

        if(name.length > 2 ) {
            statusElm.append('<div>Name is identified.</div>')
        } else {
            event.preventDefault()
            statusElm.append('<div>Please shorten your typed name.</div>')
        }

        if(subject.length > 2) {
            statusElm.append('<div>Subject is acceptable.</div>')
        } else {
            event.preventDefault()
            statusElm.append('<div>Please better describe the subject.</div>')
        }

        if(message.length > 20 && message.length < 1000) {
            statusElm.append('<div>Message can be understood.</div>')
        } else {
            event.preventDefault()
            statusElm.append('<div>Please assist to describe more.</div>')
        }

    })

})