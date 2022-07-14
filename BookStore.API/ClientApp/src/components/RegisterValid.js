export function PasswordChange() {
  const pw = document.getElementById("password").value;
  const pe = document.getElementById("passworderr");
  const numbers = /[0-9]/g;
  const upperCaseLetters = /[A-Z]/g;
  const lowerCaseLetters = /[a-z]/g;
  if (
    pw.match(upperCaseLetters) &&
    pw.length >= 8 &&
    pw.match(numbers) &&
    pw.match(lowerCaseLetters)
  ) {
    pe.classList.remove(pe.classList);
    pe.classList.add("valid");
  } else {
    pe.classList.remove(pe.classList);
    pe.classList.add("error");
  }
}

export function FirstNameChange() {
  const fn = document.getElementById("firstName").value;
  const fne = document.getElementById("firstnameerr");
  if (fn.length > 2) {
    fne.classList.remove(fne.classList);
    fne.classList.add("valid");
  } else {
    fne.classList.remove(fne.classList);
    fne.classList.add("error");
  }
}

export function LastNameChange() {
  const fn = document.getElementById("lastName").value;
  const fne = document.getElementById("lastnameerr");
  if (fn.length > 2) {
    fne.classList.remove(fne.classList);
    fne.classList.add("valid");
  } else {
    fne.classList.remove(fne.classList);
    fne.classList.add("error");
  }
}

export function usernNameChange() {
  const fn = document.getElementById("userName").value;
  const fne = document.getElementById("usernameerr");
  if (fn.length >= 4) {
    fne.classList.remove(fne.classList);
    fne.classList.add("valid");
  } else {
    fne.classList.remove(fne.classList);
    fne.classList.add("error");
  }
}

export function EmailChange() {
  const fn = document.getElementById("email").value;
  const fne = document.getElementById("emailerr");
  const re = /\S+@\S+\.\S+/;
  if (re.test(fn)) {
    fne.classList.remove(fne.classList);
    fne.classList.add("valid");
  } else {
    fne.classList.remove(fne.classList);
    fne.classList.add("error");
  }
}

export function PasswordMatchChange() {
  const pw = document.getElementById("password").value;
  const pm = document.getElementById("confirmPassword").value;
  const pe = document.getElementById("passwordmerr");
  if (pw === pm) {
    pe.classList.remove(pe.classList);
    pe.classList.add("valid");
  } else {
    pe.classList.remove(pe.classList);
    pe.classList.add("error");
  }
}
