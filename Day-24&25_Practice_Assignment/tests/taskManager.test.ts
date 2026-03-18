import { TaskManager } from "../src/services/TaskManager";

test("should create a task", () => {

  const manager = new TaskManager();

  manager.createTask({
    id: 2,
    title: "Test Task",
    status: "Pending"
  });

  const tasks = manager.getTasks();

  expect(tasks.length).toBe(2);

});