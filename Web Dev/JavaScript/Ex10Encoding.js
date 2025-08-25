function createLetterIndexMap(reference) {
  const map = new Map();
  const cleaned = reference.toLowerCase();

  for (let i = 0; i < cleaned.length; i++) {
    const char = cleaned[i];
    if (/[a-z]/.test(char) && !map.has(char)) {
      map.set(char, i); // First occurrence only
    }
  }

  return map;
}

function encryptInput(input, map) {
  const result = [];

  for (let char of input.toLowerCase()) {
    if (char === ' ') {
      result.push('-'); // Replace space with dash
    } else if (map.has(char)) {
      result.push(map.get(char));
    } else {
      result.push('?');
    }
  }

  return result;
}

const reference = prompt("Enter the reference phrase (e.g., 'The quick brown fox jumps over the lazy dog'):");
const input = prompt("Enter the word or sentence to encrypt:");

const letterMap = createLetterIndexMap(reference);
const encrypted = encryptInput(input, letterMap);

alert("Output is: " +encrypted.join(' '))
console.log("Encrypted Output:", encrypted.join(' '));
