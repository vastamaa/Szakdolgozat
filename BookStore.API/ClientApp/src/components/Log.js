import axios from 'axios';

export const populateBooksData = async () => {
    const splitUrl = window.location.href.split("/");
    console.log(splitUrl);
    let url;

    splitUrl.length === 5
        ? (url = `api/books/${splitUrl[4]}`)
        : (url = "api/books");

    axios.get(url)
        .then((response) => response)
        .catch(error => console.log(error))
};