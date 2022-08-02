import React from "react";
import ReactDOM from "react-dom/client";
import { BrowserRouter } from "react-router-dom";
import App from "./App";
import registerServiceWorker from "./registerServiceWorker";
import "./fonts/Urbanist/Urbanist-Bold.ttf";
import "bootstrap/dist/css/bootstrap.css";
import "bootstrap/dist/js/bootstrap.js";

const baseUrl = document.getElementsByTagName("base")[0].getAttribute("href");
const root = ReactDOM.createRoot(document.getElementById("root"));

root.render(
  <BrowserRouter basename={baseUrl}>
    <App />
  </BrowserRouter>
);

registerServiceWorker();
