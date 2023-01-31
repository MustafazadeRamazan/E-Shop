// Stars Rating Script
// Do this only if element with '.rating' class is found in the DOM
if (document.querySelectorAll('.rating')) {
    const ratingWrappers = document.querySelectorAll('.rating')

    ratingWrappers.forEach(rating => {
        const inputs = rating.querySelectorAll('.rating__inputs input')
        const stars = rating.querySelector('.rating__score')

        inputs.forEach(input => {
            input.addEventListener('input', () => {
                const starVal = parseInt(input.getAttribute('value'))

                // Update input rating
                stars.setAttribute('value', starVal)

                // Update rating in modal
                if (document.querySelector('#rating-modal')) {
                    document.querySelector('#rating-modal').setAttribute('value', starVal)
                    document.querySelector('#rating-form-input').setAttribute('value', starVal)
                }
            })
        })
    })
}