function getUsers() {
  return JSON.parse(localStorage.getItem('users')) || {};
}

function getActiveUsers() {
  return JSON.parse(localStorage.getItem('activeUsers')) || [];
}

function saveUsers(users) {
  localStorage.setItem('users', JSON.stringify(users));
}

function saveActiveUsers(activeUsers) {
  localStorage.setItem('activeUsers', JSON.stringify(activeUsers));
}

function clearActiveUsers() {
  localStorage.setItem('activeUsers', JSON.stringify([]));
}

function signupUser(username, password) {
  const users = getUsers();
  if (users[username]) {
    return { message: 'Username already exists!', color: 'red' };
  } else {
    users[username] = password;
    saveUsers(users);
    return { message: 'User signed up successfully!', color: 'green' };
  }
}

function loginUser(username, password) {
  const users = getUsers();
  const activeUsers = getActiveUsers();
  if (users[username] && users[username] === password) {
    if (!activeUsers.includes(username)) {
      activeUsers.push(username);
      saveActiveUsers(activeUsers);
    }
    return { message: `Welcome, ${username}!`, color: 'green' };
  } else {
    return { message: 'Invalid credentials!', color: 'red' };
  }
}

function updateActiveUsersUI(listElement) {
  const activeUsers = getActiveUsers();
  listElement.innerHTML = '';
  activeUsers.forEach(user => {
    const li = document.createElement('li');
    li.textContent = user;
    listElement.appendChild(li);
  });
}