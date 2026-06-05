"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.isStudent = isStudent;
exports.parseStudent = parseStudent;
// Type Guard: Returns a boolean to narrow down the unknown API packet safely
function isStudent(value) {
    return (typeof value === "object" &&
        value !== null &&
        "id" in value &&
        "name" in value &&
        typeof value.id === "string" &&
        typeof value.name === "string");
}
// Parse Function: Throws an explicit TypeError if validation parameters break
function parseStudent(raw) {
    if (typeof raw !== "object" || raw === null) {
        throw new TypeError(`Expected an object, received ${raw === null ? "null" : typeof raw}`);
    }
    const obj = raw;
    if (typeof obj.id !== "string") {
        throw new TypeError(`Expected id to be a string, received ${typeof obj.id}`);
    }
    if (typeof obj.name !== "string") {
        throw new TypeError(`Expected name to be a string, received ${typeof obj.name}`);
    }
    return {
        id: obj.id,
        name: obj.name,
        gpa: typeof obj.gpa === "number" ? obj.gpa : undefined,
        enrollmentDate: new Date().toISOString(),
    };
}
