// tests/inventory.test.js
const { addItem } = require('../src/inventory'); // Importa desde src/inventory.js

test('addItem should add a new item to inventory', () => {
    // 1. Prepara los datos de prueba
    const inventory = [];
    const newItem = { id: 1, name: 'Detergente', quantity: 10 };

    // 2. Ejecuta la función a probar
    addItem(inventory, newItem);

    // 3. Verifica el resultado esperado
    expect(inventory.length).toBe(1); // Chequea que la longitud del inventario sea 1
    expect(inventory[0]).toEqual(newItem); // Chequea que el primer item sea el item agregado
});
