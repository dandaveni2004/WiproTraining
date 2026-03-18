"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const TaskManager_1 = require("../src/services/TaskManager");
test("should create a task", () => {
    const manager = new TaskManager_1.TaskManager();
    manager.createTask({
        id: 1,
        title: "Build API",
        status: "Pending"
    });
    const tasks = manager.getTasks();
    expect(tasks.length).toBe(1);
});
