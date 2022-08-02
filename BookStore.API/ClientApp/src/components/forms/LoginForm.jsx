import React, { useState } from "react";
import { FormGroup, Label, Input, Form, Button } from "reactstrap";
import { handleFormLoginSubmit } from "../Log";

export const LoginForm = () => {
  const [userCredentials, setUserCredentials] = useState({
    username: "",
    password: "",
  });

  return (
    <Form
      className="mt-3"
      action="api/accounts/login"
      onSubmit={handleFormLoginSubmit}
    >
      <FormGroup>
        <Label for="username">Username</Label>
        <Input
          id="username"
          name="text"
          placeholder="Username"
          type="text"
          onChange={(event) =>
            setUserCredentials((prevState) => ({
              ...prevState,
              username: event.target.value,
            }))
          }
        />
      </FormGroup>
      <FormGroup>
        <Label for="password">Password</Label>
        <Input
          id="password"
          name="password"
          placeholder="Password"
          type="password"
          onChange={(event) =>
            setUserCredentials((prevState) => ({
              ...prevState,
              password: event.target.value,
            }))
          }
        />
      </FormGroup>
      <Button type="submit" color="danger">
        Submit
      </Button>
    </Form>
  );
};
