import React, { Component } from 'react';
import { createCookie } from './CookieHandler';
import '../custom.css';

/**
 * Helper function for POSTing data as JSON with fetch.
 *
 * param {Object} options
 * param {string} options.url - URL to POST data to
 * param {FormData} options.formData - `FormData` instance
 * return {Object} - Response body from URL that was POSTed to
 */
async function postFormDataAsJson({ url, formData }) {
    const plainFormData = Object.fromEntries(formData.entries());
    const formDataJsonString = JSON.stringify(plainFormData);

    const fetchOptions = {
        method: "POST",
        headers: {
            "Content-Type": "application/json",
            "Accept": "application/json",
        },
        body: formDataJsonString,
    };

    const response = await fetch(url, fetchOptions);

    if (!response.ok) {
        const errorMessage = await response.text();
        throw new Error(errorMessage);
    }

    return await response.json();
}

/**
 * Event handler for a form submit event.
 *
 * see https://developer.mozilla.org/en-US/docs/Web/API/HTMLFormElement/submit_event
 *
 * param {SubmitEvent} event
 */
async function handleFormSubmit(event) {
    event.preventDefault();

    const form = event.currentTarget;
    const url = form.action;

    try {
        const formData = new FormData(form);
        const responseData = await postFormDataAsJson({ url, formData });

        createCookie("token", responseData.access_token);

        console.log("Sikeres");
    } catch (error) {
        console.error(error);
    }
}



export class Login extends Component {
    static displayName = Login.name;

    constructor(props) {
        super(props);
    }


    render() {
        return (
            <div>
                <h1 className="mb-4 mt-4">Login:</h1>
                <div id="error"></div>
                <form action='api/account/login' onSubmit={handleFormSubmit}>
                    <div className="form-group mb-4">
                        <label htmlFor="email">Email</label>
                        <input type="text" className="form-control" name="email" id="email" placeholder="Enter email address" />
                    </div>
                    <div className="form-group mb-4">
                        <label htmlFor="password">Password</label>
                        <input type="password" className="form-control" name="password" id="password" placeholder="Enter your password" />
                    </div>
                    <button type="submit" className="btn btn-outline-danger my-2 my-sm-0">Submit</button>
                </form>
            </div>
        );
    }
}
