import { createCookie, eraseCookie } from './CookieHandler'

/**
 * Helper function for POSTing data as JSON with fetch.
 *
 * param {Object} options
 * param {string} options.url - URL to POST data to
 * param {FormData} options.formData - `FormData` instance
 * return {Object} - Response body from URL that was POSTed to
 */
async function postFormDataAsJson ({ url, formData }) {
  const plainFormData = Object.fromEntries(formData.entries())
  const formDataJsonString = JSON.stringify(plainFormData)

  const fetchOptions = {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      Accept: 'application/json'
    },
    body: formDataJsonString
  }

  const response = await fetch(url, fetchOptions)

  if (!response.ok) {
    const errorMessage = await response.text()
    throw new Error(errorMessage)
  }

  return await response.json()
}

/**
 * Event handler for a form submit event.
 *
 * see https://developer.mozilla.org/en-US/docs/Web/API/HTMLFormElement/submit_event
 *
 * param {SubmitEvent} event
 */
export async function handleFormLoginSubmit (event) {
  event.preventDefault()

  const form = event.currentTarget
  const url = form.action
  try {
    const formData = new FormData(form)
    const responseData = await postFormDataAsJson({ url, formData })

    createCookie('token', responseData.token)

    console.log('Sikeres!')
    window.location.replace('https://localhost:5001/')
  } catch (error) {
    console.error(error)
  }
}

export async function handleFormRegisterSubmit (event) {
  event.preventDefault()

  const form = event.currentTarget
  const url = form.action

  try {
    const formData = new FormData(form)
    const responseData = await postFormDataAsJson({ url, formData })

    console.log(responseData)
    window.location.replace('https://localhost:5001/')
  } catch (error) {
    console.error(error)
  }
}

export function handleResetPasswordSubmit () {}

export function logOut () {
  eraseCookie('token')
  window.location.replace('/')
  return false
}
