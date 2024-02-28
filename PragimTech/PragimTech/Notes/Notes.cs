
// ===================================  01 =============================================
/*
 * This:
 *  this refers to an instance of that class to an object of this class. Why?
 *  cuz when we use . on this it show all the fields of the class
 *  
 *  Destructors:
 *   Destructors dont have param and no return type. It is use to clean up the resources your class was holding on during its   lifetime . Any code which is holding something we put them in destructors.
 *   Destructors is automatically called by the garbage colllector when it tries to clean obj from memory
 * 
 */

// ===================================  02 =============================================
/*
 * Something which is not changing we make them static
 * All class members(fields, constructors etc.) can be either static or instance
 * 
 * To init instance field use instance constructor.
 * To init static field use static constructor.
 * AM are not allowed on static constructor
 * We dont have to call static constructor explicitly. Cuz when we are refering static field Constructor will be automatically called before that to init static field. Why?
 * Cuz if u make it public someone will call that constructor
 * 
 * Static Constructors are called before instace constructor and even before u refer to any static field cuz the need to be init and called only once to init the obj but instace will be called every time whenever u create the obj
 * 
 */


