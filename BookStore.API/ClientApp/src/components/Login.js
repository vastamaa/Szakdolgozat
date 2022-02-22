import React, { Component } from 'react';
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

    return response.body;
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

        console.log(responseData);
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
                <h1 className="page-header">Login:</h1>

                <form action='api/account/login' onSubmit={handleFormSubmit}>
                    <div className="form-group">
                        <label htmlFor="email">Email</label>
                        <input type="text" className="form-control" name="email" id="email" placeholder="Enter email address" />
                    </div>
                    <div className="form-group">
                        <label htmlFor="password">Password</label>
                        <input type="password" className="form-control" name="password" id="password" placeholder="Enter your password" />
                    </div>
                    <button type="submit" id="btn" className="btn btn-primary">Submit</button>
                </form>
            </div>
        );
    }
}
