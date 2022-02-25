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



export class Register extends Component {
    static displayName = Register.name;

    constructor(props) {
        super(props);
    }


    render() {
        return (
            <div>
                <div>
                    <h1 className="mb-4 mt-4">Register:</h1>

                    <form action='api/account/register' onSubmit={handleFormSubmit}>
                        <div className="form-group mb-4">
                            <label htmlFor="firstName">First Name</label>
                            <input type="text" className="form-control" name="firstName" id="firstName" placeholder="Enter first name" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="lastName">Last Name</label>
                            <input type="text" className="form-control" name="lastName" id="lastName" placeholder="Enter last name" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="exampleInputEmail1">Email address</label>
                            <input type="email" className="form-control" name="email" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Enter email" />
                            <small id="emailHelp" className="form-text text-muted">We'll never share your email with anyone else.</small>
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="password">Password</label>
                            <input type="password" className="form-control" name="password" id="password" placeholder="Password" />
                        </div>
                        <div className="form-group mb-4">
                            <label htmlFor="confirmPassword">Confirm Password</label>
                            <input type="password" className="form-control" name="confirmPassword" id="confirmPassword" placeholder="Password" />
                        </div>
                        <button type="submit" className="btn btn-outline-danger my-2 my-sm-0">Submit</button>
                    </form>
                </div>
            </div>
        );
    }
}
